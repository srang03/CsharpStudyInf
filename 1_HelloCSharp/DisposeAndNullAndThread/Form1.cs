using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisposeAndNullAndThread
{
    public enum Status
    {
        Disconnection,
        Connection,
        StorageLoaded
    }
    public partial class Form1 : Form
    {
        ConnectWorkUserControl _control;
        private Status status;
        public Form1()
        {
            InitializeComponent();
            status = Status.Disconnection;
            this.lbl_state.Text = status.ToString();
        
        }

        private void StartControl()
        {
            if(_control == null)
            {
                _control = new ConnectWorkUserControl();
                this.panel1.Controls.Add(_control);
                _control.Dock = DockStyle.Fill;
            }
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            _control.IsRead = true;
            status = Status.Connection;
            this.lbl_state.Text = status.ToString();
            this.lbl_log.Items.Add("디바이스가 연결되었습니다.");
        }

        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            status = Status.Disconnection;
            this.lbl_state.Text = status.ToString();
            _control.thread1.Interrupt();
            _control.thread2.Interrupt();
            _control.Dispose();
            _control = null;
            this.lbl_log.Items.Add("디바이스의 연결이 해제되었습니다.");
        }

        private void btn_storageConnection_Click(object sender, EventArgs e)
        {
            if(status == Status.Connection)
            {
                _control.IsReadInternalStorage = true;
                status = Status.StorageLoaded;
                this.lbl_state.Text = status.ToString();
                this.lbl_log.Items.Add("디바이스의 Internal Storage가 정상적으로 로드되었습니다.");
            } 
        }

        private void btn_init_Click(object sender, EventArgs e)
        {
            StartControl();
        }
    }
}
