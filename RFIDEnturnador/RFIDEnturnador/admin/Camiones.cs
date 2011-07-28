using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Collections;
using EnturnadorDAO;
using EnturnadorLIB;
using Ensyc;
using Ensyc.RF1200;



namespace RFIDEnturnador.admin
{
    public partial class Camiones : Form
    {
        private EnturnadorLIB.Enturnador.Camion objCamion;
        private EnturnadorLIB.Enturnador.Util objUtil;
        private int idCamion;
        List<TIPO_CARGUE> listaTipoCargue;

        /// <summary>
        /// Variables relacionadas con el manejo de la lectora
        /// </summary>
        private EReader mReader; //m stands for member variable
        private delegate void dlProcessResponse(EReader.Response EResponse);        

        private enum Vista
        { 
            LISTA = 0,
            NUEVO,
            CARGUE
        }

        public Camiones()
        {
            InitializeComponent();
        }

        private void Camiones_Load(object sender, EventArgs e)
        {
            //Para poder abrir el dialogo para seleccionar el archivo y pode procesarlo en un hilo diferente
            CheckForIllegalCrossThreadCalls = false;

            this.objCamion = new EnturnadorLIB.Enturnador.Camion();

            this.CambiarVista(Vista.LISTA);
            
            this.GetCamiones();
            this.LlenarComboTipoCargue();
        }

        #region "Métodos privados"

        private void GetCamiones()
        {
            this.grdCamiones.AutoGenerateColumns = false;
            DataTable dtCamiones = this.objCamion.GetAll();
            this.grdCamiones.DataSource = dtCamiones;

            this.grdCamiones.Columns["PLACA"].Width = 130;
            this.grdCamiones.Columns["TIPOCARGUE"].Width = 200;
            this.grdCamiones.Columns["EDITAR"].Width = 95;
            this.grdCamiones.Columns["ELIMINAR"].Width = 95;
            this.grdCamiones.Columns["TIPOCARGUE"].HeaderText = "TIPO CARGUE";
        }

        private void LlenarComboTipoCargue()
        {
            EnturnadorLIB.Enturnador.Lista objLista = new EnturnadorLIB.Enturnador.Lista();
            this.listaTipoCargue = objLista.GetListaTipoCargue();

            //Se inserta item de "seleccione" a la lista
            TIPO_CARGUE sel = new TIPO_CARGUE();
            sel.id = 0;
            sel.tipoCargue = "Seleccione...";
            listaTipoCargue.Insert(0, sel);            

            this.cboTipoCargue.DataSource = listaTipoCargue;
            this.cboTipoCargue.DisplayMember = "tipoCargue";
            this.cboTipoCargue.ValueMember = "id";            
        }


        private void CambiarVista(Vista vista)
        {
            if (vista == Vista.LISTA)
            {
                splitContainer1.Panel1Collapsed = false;
                splitContainer1.Panel2Collapsed = true;
                this.idCamion = 0;
                this.panelCargueMasivo.Visible = false;
            }
            else if(vista == Vista.NUEVO)
            {
                splitContainer1.Panel1Collapsed = true;
                splitContainer1.Panel2Collapsed = false;
                this.panelCargueMasivo.Visible = false;
                this.ConectarLectora();
            }
            else if (vista == Vista.CARGUE)
            {
                this.panelCargueMasivo.Visible = true;
                this.panelCargueMasivo.Height = 476;
            }
        }

        private void Limpiar()
        {
            this.idCamion = 0;
            this.txtPlaca.Text = "";
            this.cboTipoCargue.SelectedIndex = 0;
            this.txtCodigoRFID.Text = "";
        }

        private void Editar()
        {
            this.CambiarVista(Vista.NUEVO);

            //Se obtienen los datos actuales
            CAMION obj = this.objCamion.GetById(this.idCamion);

            if (obj == null)
            {
                MessageBox.Show("No se encontró la información del camión seleccionado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.txtPlaca.Text = obj.placa;
            this.cboTipoCargue.SelectedValue = obj.idTipoCargue;
            this.txtCodigoRFID.Text = obj.codigoRFID;            
        }

        private void Eliminar()
        {
            if (MessageBox.Show("¿Realmente desea eliminar este camión?", "Eliminar camión", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.objCamion.Eliminar(this.idCamion, RFIDEnturnador.CGlobal.IdUsuario);
                this.GetCamiones();
            }
        }

        /// <summary>
        /// Valida los datos para la creacion de un camion
        /// </summary>
        /// <returns></returns>
        private bool Validar()
        {
            string mensaje = string.Empty;

            if (this.txtPlaca.Text.Trim().Length == 0)
                mensaje += "- La placa no puede quedar vacía\n";
            else
            { 
                if(this.txtPlaca.Text.Length != 6)
                    mensaje += "- La placa no puede tener espacios y debe tener 6 caracteres\n";
            }

            if (this.cboTipoCargue.SelectedIndex == 0)
                mensaje += "- Debe seleccionar el tipo de cargue\n";

            if (mensaje.Length > 0)
            {
                MessageBox.Show("Por favor complete la siguiente información: \n" + mensaje, "Información incompleta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }            

            return true;
        }

        private void Guardar()
        {
            try
            {
                CAMION cam = new CAMION();
                cam.codigoRFID = "";
                cam.idTipoCargue = Convert.ToInt32(this.cboTipoCargue.SelectedValue);
                cam.placa = this.txtPlaca.Text;
                cam.codigoRFID = this.txtCodigoRFID.Text;
                cam.activo = true;

                //Si se esta creando el camion
                if (this.idCamion == 0)
                {
                    this.objCamion.Crear(cam, RFIDEnturnador.CGlobal.IdUsuario);
                    MessageBox.Show("El camión ha sido creado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    cam.id = this.idCamion;
                    this.objCamion.Actualizar(cam, RFIDEnturnador.CGlobal.IdUsuario);
                    MessageBox.Show("El camión se ha actualizado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.GetCamiones();
                this.Limpiar();
                this.CambiarVista(Vista.LISTA);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar el camión: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                string inner = "";
                if (ex.InnerException != null)
                    inner = ex.InnerException.Message;
                this.objUtil.LogError("Camiones", "Guardar", ex.Message, inner, CGlobal.IdUsuario);
            }
        }

        /// <summary>
        /// Lee el archivo de texto que contiene los camiones a cargar
        /// </summary>
        /// <param name="ruta"></param>
        private void LeerArchivo(string ruta)
        {
            if (!File.Exists(ruta))
            {
                MessageBox.Show("No se encontró el archivo", "Archivo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Cursor = Cursors.WaitCursor;

            //Tabla que guardara los registros con error
            DataTable dtError = new DataTable();
            dtError.Columns.Add("FILA");
            dtError.Columns.Add("ERROR");
            DataRow dr;

            string line;
            int contador = 1;           //Variable que va contando el numero de filas leidas                         
            string error = string.Empty;

            try
            {
                StreamReader sr = new StreamReader(ruta);
                line = sr.ReadLine();
                while (line != null)
                {
                    error = this.ProcesarLinea(line);

                    //Si se encontro algun error
                    if (error.Length > 0)
                    {
                        dr = dtError.NewRow();
                        dr["FILA"] = contador.ToString();
                        dr["ERROR"] = error;
                        dtError.Rows.Add(dr);
                    }

                    error = "";
                    contador += 1;
                    line = sr.ReadLine();
                }

                sr.Close();

                //Se muetsran los errores y totales
                this.lblCantidadLeida.Text = "Registros en el archivo: " + contador.ToString();
                this.lblCantidadGuardada.Text = "Cantidad guardada exitosamente: " + (contador - dtError.Rows.Count).ToString();
                this.lblCantidadError.Text = "Registros con error: " + dtError.Rows.Count.ToString();

                //this.grdCargue.AutoGenerateColumns = false;
                this.grdCargue.DataSource = dtError;
                this.grdCargue.Columns["FILA"].Width = 70;

                Cursor = Cursors.Default;
                MessageBox.Show("Ha finalizado el proceso de cargue masivo", "Proceso finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show("Ocurrió un error al leer el archivo: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                string inner = "";
                if (ex.InnerException != null)
                    inner = ex.InnerException.Message;
                this.objUtil.LogError("Camiones", "LeerArchivo", ex.Message, inner, CGlobal.IdUsuario);
            }            
        }

        /// <summary>
        /// Procesa una linea leida del archivo de cargue masivo. Si todo sale OK retorna una cadena vacia, de lo contrario retorna el error
        /// </summary>
        private string ProcesarLinea(string linea)
        {
            string error = string.Empty;
            String[] arrLinea;
            string placa = string.Empty;
            string tipoDescargue = string.Empty;
            string codigoRFID = string.Empty;
            int idTipoCargue = 0;
            TIPO_CARGUE objTipoCargue;
            CAMION objCamionTemp;

            if (linea.Contains("|"))
            {
                arrLinea = linea.Split('|');
                if (arrLinea.Count() >= 2)
                {
                    placa = arrLinea[0].Trim();
                    tipoDescargue = arrLinea[1].Trim();
                    codigoRFID = "";
                    idTipoCargue = 0;

                    if (arrLinea.Count() >= 3)
                        codigoRFID = arrLinea[2].Trim();

                    //Validacion de la estructura de la placa
                    if (placa.Length == 0)
                        error += "- La placa no puede quedar vacía\n";
            
                    else
                    {
                        if (placa.Length != 6)
                            error += "- La placa no puede tener espacios y debe tener 6 caracteres\n";
                    }

                    //Validacion del tipo de descargue
                    if (tipoDescargue.Length == 0)
                        error += "- El tipo de descargue no puede quedar vacío\n";
                    else
                    { 
                        //Se busca el id de tipo de cargue correspondiente
                        objTipoCargue = this.listaTipoCargue.Find(t => t.tipoCargue == tipoDescargue);
                        if(objTipoCargue != null)
                            idTipoCargue = objTipoCargue.id;
                        else
                            error += "- No se encontró el tipo de descargue correspondiente a '" + tipoDescargue + "'\n";
                    }

                    //Se inserta el registro
                    if (error.Length == 0)
                    {
                        try
                        {
                            objCamionTemp = new CAMION();
                            objCamionTemp.activo = true;
                            objCamionTemp.codigoRFID = codigoRFID;
                            objCamionTemp.idTipoCargue = idTipoCargue;
                            objCamionTemp.placa = placa;
                            this.objCamion.Crear(objCamionTemp, CGlobal.IdUsuario);
                        }
                        catch (Exception ex)
                        {
                            error += ex.Message + "\n";
                        }                    
                    }

                }
                else
                {
                    error = "El registro no tiene el formato especificado";
                }
            }
            else
            {
                error = "El registro no tiene el formato especificado";
            }

            return error;
        }

        private void AbrirDialogo()
        {
            //Se abre el dialogo para seleccionar el archivo con los datos a cargar
            this.openFileDialog1.Filter = "Text files(*.txt)|*.txt";
            this.openFileDialog1.Multiselect = false;
            this.openFileDialog1.ShowDialog();
        }

        #endregion

        #region "Lectora"

        /// <summary>
        /// Determina el estado de la lectora y coloca un icono verde o rojo que muestra el estado detectado
        /// </summary>
        private void ConectarLectora()
        {
            try
            {
                //Get an array of connected readers
                int[] iReaders = Utility.GetConnectedReaders();
                if (iReaders.Length > 0)
                {
                    //Now we found reader so lets connect it.
                    if (iReaders.Length > 1)
                    {
                        //We have multiple reader connected to system. 
                        //Handle this properly
                    }
                    else
                    {
                        //Create instance of the object
                        mReader = new EReader();
                        //Open virtula serial port reader is connected to.
                        mReader.Open(iReaders[0]);
                        //Now add reader response event handler
                        mReader.ReaderResponse += new dlReaderResponse(mReader_ReaderResponse);
                        this.pictureLectora.Image = RFIDEnturnador.Properties.Resources.Ball_green_32;
                    }

                }
                else
                {
                    this.pictureLectora.Image = RFIDEnturnador.Properties.Resources.Ball_red_32;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al conectarse a la lectora, por favor intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                string inner = "";
                if (ex.InnerException != null)
                    inner = ex.InnerException.Message;
                this.objUtil.LogError("Camiones", "LeerArchivo", ex.Message, inner, CGlobal.IdUsuario);
            }
        }

        void mReader_ReaderResponse(EReader.Response EResponse)
        {
            this.Invoke(new dlProcessResponse(ProcessReaderResponse), new object[] { EResponse });
        }

        /// <summary>
        /// Manejador del evento de la respuesta de la lectora
        /// </summary>
        /// <param name="EResponse"></param>
        void ProcessReaderResponse(EReader.Response EResponse)
        {
            try
            {
                //Now when reader response is MSG_OK we will process command.
                //MSG_OK means reader received command successfully and command was executed successfully.
                //It doesn't mean reader was able to read tag (in case of ReadTag() command). 
                //It is just indicator of reader tried to read tag successfully.
                //But if we have message other than MSG_OK, it indicates failure.

                if (EResponse.ResponseCode == EReader.CommandCode.MSGOK)
                {
                    //Now parse response as we need
                    //Now most of the command like write tag, write tag memory, set hardware information 
                    //just needs confirmation of successfull execution so MSG_OK response indicates success for such commands.
                    //Where as other commands like read tag, read tag memory, get hardware information, get firmware version
                    //response comes back with some kind of data in response to issued command.
                    //For such cases each command has different kind of response, so we need different way to parse it.
                    //We have made this easy for developer by using response class for each specific command.
                    //Here you will see how to use it.


                    //We know the respone is MSG_OK (inside if ) so we can check for command specific response.
                    //Here we have illustrated few commands. You can add more response as you need
                    switch (EResponse.CommandEcho)
                    {
                        case EReader.Command.GET_FIRMWARE_VERSION:
                            //If response is not null then
                            if (EResponse.CommandSpecificResponse != null)
                            {
                                //Now we want to parse specific response as per GET_FIRMWARE_VERSION command
                                //No problem
                                EReader.FirmwareResponse specificRes = (EReader.FirmwareResponse)EResponse.CommandSpecificResponse; //This is easy
                                //Now you can process values easily Try yourself by typing specificRes.
                                //specificRes.MinorVersion 
                            }
                            break;
                        case EReader.Command.READ_TAG:
                            //If response is not null then
                            if (EResponse.CommandSpecificResponse != null)
                            {
                                EReader.ReadTagResponse specificRes = (EReader.ReadTagResponse)EResponse.CommandSpecificResponse; //This is easy
                                //Now for the case of read_tag command we have to see if we were able to find any tag or not before we can look for tag value
                                if (specificRes.Decode == EReader.ReadTagResponse.TagDecode.GOOD_TAG)
                                {
                                    //Hurreyy..we found good tag now we can use tag value for business logic.
                                    byte[] bTagData = specificRes.TagData; //Get tag data as an array
                                    string sTagData = Utility.ToHex(specificRes.TagData);//convert tag data as string of Hex
                                    string tag = Utility.ByteToString(bTagData);
                                    tag.TrimStart();
                                    tag = tag.Replace("\0", "");

                                    //MessageBox.Show(this, "Hexa: " + sTagData + "\n" + "Barcode: " + tag, "Lectura", MessageBoxButtons.OK);
                                    this.txtCodigoRFID.Text = sTagData;

                                }
                                else
                                {
                                    //MessageBox.Show("no tag found. Display proper message");
                                    //no tag found. Display proper message.
                                }

                            }
                            break;
                        case EReader.Command.READ_TAG_MEMORY:
                            //As per previous examples
                            if (EResponse.CommandSpecificResponse != null)
                            {
                                EReader.ReadTagMemoryResponse specificRes = (EReader.ReadTagMemoryResponse)EResponse.CommandSpecificResponse; //This is easy
                                //Now for the case of read_tag command we have to see if we were able to find any tag or not before we can look for tag value
                                if (specificRes.Decode == EReader.ReadTagMemoryResponse.TagDecode.GOOD_TAG)
                                {
                                    //Hurreyy..we found good tag now we can use tag value for business logic.
                                    byte[] bTagData = specificRes.TagData; //Get tag data as an array
                                    string sTagData = Utility.ToHex(specificRes.TagData);//convert tag data as string of Hex
                                }
                                else
                                {
                                    //no tag found. Display proper message.
                                }
                            }
                            break;
                    }
                }
                else
                {
                    //Print error message only in debugging mode
                    MessageBox.Show("Intente la operación nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                //Se guarda log del error
                MessageBox.Show("Ocurrió un error durante la operación d electura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                string inner = "";
                if (ex.InnerException != null)
                    inner = ex.InnerException.Message;
                this.objUtil.LogError("Camiones", "ProcessReaderResponse", ex.Message, inner, CGlobal.IdUsuario);
            }
        }

        /// <summary>
        /// Lee la lectora en busca de un tag.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureLectora_Click(object sender, EventArgs e)
        {
            //la lectora debe estar conectada
            if (mReader != null)
            { 
                if (mReader.IsConnected == true)
                    mReader.ReadTag();
                else
                    MessageBox.Show("No se puede hacer la lectura porque la lectora está desconectada", "Lectora desconectada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
        }

        //Procedure to close connection with reader. This is for safe practice only.
        private void DisconnectReader()
        {
            try
            {
                //If reader instace is set then only close connection
                if (mReader != null)
                {
                    //if reader is connected then only we can disconnect
                    if (mReader.IsConnected == true)
                    {
                        mReader.Close();
                        mReader.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                string inner = "";
                if (ex.InnerException != null)
                    inner = ex.InnerException.Message;
                this.objUtil.LogError("Camiones", "DisconnectReader", ex.Message, inner, CGlobal.IdUsuario);
            }
        }



        #endregion


        #region "Eventos"


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.CambiarVista(Vista.NUEVO);
        }


        private void grdCamiones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.idCamion = Convert.ToInt32(this.grdCamiones.Rows[e.RowIndex].Cells["ID"].Value);

            switch (this.grdCamiones.Columns[e.ColumnIndex].Name)
            { 
                case "EDITAR":
                    this.Editar();
                    break;
                case "ELIMINAR":
                    this.Eliminar();
                    break;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();            
            this.CambiarVista(Vista.LISTA);
            this.DisconnectReader();
        }

        private void btnListo_Click(object sender, EventArgs e)
        {
            if (this.Validar())
            {
                this.Guardar();
                this.DisconnectReader();
            }                
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.grdCamiones.AutoGenerateColumns = false;
            DataTable dtCamiones = this.objCamion.GetCamionesByPlaca(this.txtBuscarPlaca.Text);
            this.grdCamiones.DataSource = dtCamiones;

            if (dtCamiones.Rows.Count == 0)
                MessageBox.Show("No se encontraron camiones", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.grdCamiones.Columns["PLACA"].Width = 130;
            this.grdCamiones.Columns["TIPOCARGUE"].Width = 200;
            this.grdCamiones.Columns["EDITAR"].Width = 95;
            this.grdCamiones.Columns["ELIMINAR"].Width = 95;
            this.grdCamiones.Columns["TIPOCARGUE"].HeaderText = "TIPO CARGUE";
        }

        private void btnVerCargue_Click(object sender, EventArgs e)
        {
            this.CambiarVista(Vista.CARGUE);
        }

        /// <summary>
        /// Estando en el panel de carga masiva se presiona cancelar: se vuelve a mostrar la lista de camiones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelarCarga_Click(object sender, EventArgs e)
        {
            this.CambiarVista(Vista.LISTA);
        }

        [STAThread]
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            Thread hilo = new Thread(AbrirDialogo);
            hilo.IsBackground = true;
            hilo.SetApartmentState(ApartmentState.STA);
            hilo.Start();
        }

        [STAThread]
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            this.LeerArchivo(this.openFileDialog1.FileName);
        }

        private void Camiones_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DisconnectReader();
        }


        #endregion








    }
}
