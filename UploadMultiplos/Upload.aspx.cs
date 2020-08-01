using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace UploadMultiplos
{
    public partial class Upload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                //Metodo que organiza os arquivos carregado pelo cliente e monta uma coleção de arquivos passados pelo FileUpload
                HttpFileCollection hfc = Request.Files;

                for (int i = 0; i < hfc.Count; i++)
                {
                    //Metodo HttpPostedFile ao contrario do httpFileCollection ele fornece
                    //as informações de um arquivo para ler ou ser salvo.

                    HttpPostedFile hpf = hfc[i];

                    fuArquivos.SaveAs(Server.MapPath("Arquivos") + "\\" + System.IO.Path.GetFileName(hpf.FileName));
                    Page.ClientScript.RegisterClientScriptBlock(Page.GetType(), "Sucesso", "alert('Upload efetuado com sucesso')", true);

                    //Caso quera o nome dos arquivos para salvar no banco a linha abaixo informa os nomes
                    //string nameFiles = hpf.FileName;
                }
            }
            catch (Exception ex)
            {
                Page.ClientScript.RegisterClientScriptBlock(Page.GetType(), "Erro", "alert('"+ex.Message+"')", true);
            }
        }
    }
}