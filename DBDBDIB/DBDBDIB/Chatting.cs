using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EngineIOSharp.Common.Enum;
using Newtonsoft.Json.Linq;
using SocketIOSharp.Client;
using SocketIOSharp.Common;

namespace DBDBDIB
{
    public partial class Chatting : Form
    {
        UserInfo UserManager = UserInfo.Getinstance();
        delegate void Ctr_Invok(Control ctr, String text);
        public void setText_Control(Control ctr, string txtValue)
        {
            if (ctr.InvokeRequired)
            {
                Ctr_Invok Cl = new Ctr_Invok(setText_Control);
                ctr.Invoke(Cl, ctr, txtValue);
            }
            else
            {
                ctr.Text += txtValue;
                ctr.Text += "\n";
            }
        }

        SocketIOClient client = new SocketIOClient(new SocketIOClientOption(EngineIOScheme.http, "localhost", 9001));
        public Chatting()
        {
            InitializeComponent();
        }
        private void Chatting_Load(object sender, EventArgs e)
        {
            usingChat();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string line = txtUserMsg.Text.ToString();

            var json = new JObject();
            json.Add("name", UserManager.Name);
            json.Add("room", txtRoomNum.Text);
            json.Add("msg", line);

            Console.WriteLine(json.ToString());

            client.Emit("chat message", json);
            txtUserMsg.Text = "";
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            var json = new JObject();
            json.Add("name", UserManager.Name);
            json.Add("room", txtRoomNum.Text);
            json.Add("msg", "채팅을 시작합니다.");

            Console.WriteLine(json.ToString());

            client.Emit("chat message", json);
        }

        public void usingChat()
        {
            InitEventHandlers(client);

            client.Connect();
            txtBoxMsg.Text = "Input /exit to close connection.\n";
        }

        public void InitEventHandlers(SocketIOClient client)
        {
            client.On(SocketIOEvent.CONNECTION, () =>
            {
                Console.WriteLine("Connected!");
            });

            client.On(SocketIOEvent.DISCONNECT, () =>
            {
                Console.WriteLine();
                Console.WriteLine("Disconnected!");
            });


            client.On("chat message", (Data) =>
            {
                Console.WriteLine("Echo : " + (Data[0].Type == JTokenType.Bytes ? BitConverter.ToString(Data[0].ToObject<byte[]>()) : Data[0]));

                Console.WriteLine("This is me " + Data[0]);

                // Delegate 사용 -> 폼에 메시지 추가
                setText_Control((Control)txtBoxMsg, (string)Data[0]);

            });

        }

        private void Chatting_FormClosed(object sender, FormClosedEventArgs e)
        {
            client.Close();
        }
    }
}
