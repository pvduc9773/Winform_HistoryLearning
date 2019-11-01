using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppG2.Model;
using AppG2.Controller;

namespace AppG2.View
{
    public partial class frmHistoryLearningDetail : Form
    {
        HistoryLearning historyLearning;
        string pathHistoryLeaningDataFile;
        string idStudent;

        public frmHistoryLearningDetail(string pathHistoryLeaningDataFile, string idStudent, HistoryLearning historyLearning = null)
        {
            InitializeComponent();
            this.historyLearning = historyLearning;
            this.pathHistoryLeaningDataFile = pathHistoryLeaningDataFile;
            this.idStudent = idStudent;
            if (historyLearning != null)
            {
                // Chỉnh sửa quá trình học tập
                numTuNam.Value = historyLearning.yearFrom;
                numDenNam.Value = historyLearning.yearEnd;
                txtNoiHoc.Text = historyLearning.address;
            }
            else
            {
                // Thêm mới quá trình học tập

            }
        }

        private void FrmHistoryLearningDetail_Load(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (historyLearning != null)
            {
                // Cập nhật
                StudentService.updateHistoryLearning(pathHistoryLeaningDataFile, historyLearning.idHistoryLearning, Int32.Parse(numTuNam.Value.ToString()), Int32.Parse(numDenNam.Value.ToString()), txtNoiHoc.Text.ToString());
            }
            else
            {
                // Thêm mới
                StudentService.addNewHistoryLearning(pathHistoryLeaningDataFile, Int32.Parse(numTuNam.Value.ToString()), Int32.Parse(numDenNam.Value.ToString()), txtNoiHoc.Text.ToString(), idStudent);

            }
            MessageBox.Show("Đã cập nhật dữ liệu thành công");
            DialogResult = DialogResult.OK;
        }
    }
}
