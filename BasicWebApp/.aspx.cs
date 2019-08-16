using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HP.HPTRIM.Service.Client;
using HP.HPTRIM.ServiceModel;
using System.Net;

namespace BasicWebApp
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                TrimClient trimClient = new TrimClient("http://10.99.100.107/CMServiceAPI"); //change ip address at home 
                trimClient.Credentials = new System.Net.NetworkCredential("trimservices", "Password1", "TrimDemo");

                Records request = new Records()
                {
                    q = "RecordType:{Document}", //unique id 4 can also use (title:record),
                    Properties = new PropertyList(PropertyIds.RecordTitle),
                };

                Record record = trimClient.Get<RecordsResponse>(request).Results.First();

                Label1.Text = record.Title;
            }
            catch(Exception ex)
            {
                Label1.Text = ex.ToString();
            }
        }
    }
}