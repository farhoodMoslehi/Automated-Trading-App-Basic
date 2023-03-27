using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBApi;



namespace IB_TradingPlatform
{
    public partial class Form1 : Form
    {
        // This delegate enables asynchronous calls for setting the text property on a ListBox control
        delegate void SetTextCallback(string text);

        //Create the ibclient object to represent the connection
        IB_TradingPlatform.EWrapperImpl ibClient;
        public Form1()
        {
            InitializeComponent();
            //instantiate the IB client
            ibClient = new IB_TradingPlatform.EWrapperImpl();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            // Parameters to connect to TWS are:
            // host         -IP address or host name of the host running TWS
            // port         -listening port 7496
            //clientId      -client application identifier can be any number

            ibClient.ClientSocket.eConnect("", 7496, 0);

        }
    }
}