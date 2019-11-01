using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppG2.Controller;
using AppG2.Model;
using AppG2.View;

namespace AppG2
{
    public partial class frmThongTinSinhVien : Form
    {
        #region Variables to process Image Avatar 
        Image image;
        string pathDirectoryImg;
        string pathAvatarImg;
        string pathStudentDataFile;
        string pathHistoryLeaningDataFile;
        string idStudent = "16T1021222";
        #endregion

        public frmThongTinSinhVien()
        {
            InitializeComponent();
            pathDirectoryImg = Application.StartupPath + "\\Img";
            pathAvatarImg = pathDirectoryImg + "\\avatar.png";
            picAnhDaiDien.AllowDrop = true;

            pathStudentDataFile = Application.StartupPath + @"\Data\student.txt";
            pathHistoryLeaningDataFile = Application.StartupPath + @"\Data\history_learning.txt";

            bdsQuaTrinhHocTap.DataSource = null;
            dtgQuaTrinhHocTap.AutoGenerateColumns = false;

            if (File.Exists(pathAvatarImg))
            {
                FileStream fileStream = new FileStream(pathAvatarImg, FileMode.Open, FileAccess.Read);
                picAnhDaiDien.Image = Image.FromStream(fileStream);
                fileStream.Close();
            }
            var student = StudentService.getStudent(pathStudentDataFile, idStudent);
            
            if (student == null)
            {
                throw new Exception("Không tồn tại sinh viên này.");
            }
            else
            {
                updateDisplayInfoStudent(student);
                updateTableHistoryLearning(StudentService.getHistoryLearning(pathHistoryLeaningDataFile, idStudent));
            }
        }

        private void LnkChonAnhDaiDien_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn ảnh đại diện";
            openFileDialog.Filter = "File ảnh(*.png, *.jpg)|*.png;*.jpg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                image = Image.FromFile(openFileDialog.FileName);
                picAnhDaiDien.Image = image;
            }
        }

        private void BtnCapNhat_Click(object sender, EventArgs e)
        {
            #region Cập nhật hình đại diện
            bool imageSave = false;
            if (image != null)
            {
                if (!Directory.Exists(pathDirectoryImg))
                {
                    Directory.CreateDirectory(pathDirectoryImg);
                }
                image.Save(pathAvatarImg);
                imageSave = true;
            }
            #endregion

            if (imageSave)
            {
                MessageBox.Show(
                    "Đã cập nhật thông tin sinh viên thành công",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            }
        }

        private void PicAnhDaiDien_DragDrop(object sender, DragEventArgs e)
        {
            var rs = (string[])e.Data.GetData(DataFormats.FileDrop);
            var filePath = rs.FirstOrDefault();
            image = Image.FromFile(filePath);
            picAnhDaiDien.Image = image;
        }

        private void PicAnhDaiDien_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void MniXoaAnhDaiDien_Click(object sender, EventArgs e)
        {
            picAnhDaiDien.Image = Properties.Resources.avatar;
            File.Delete(pathAvatarImg);
        }

        private void PicAnhDaiDien_Click(object sender, EventArgs e)
        {

        }

        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            var rs = MessageBox.Show("Bạn có muốn xóa dữ liệu này không ?",
                "Thông Báo",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);
            if (rs == DialogResult.OK)
            {
                var history = bdsQuaTrinhHocTap.Current as HistoryLearning;
                StudentService.deleteHistoryLearning(pathHistoryLeaningDataFile, history.idHistoryLearning);
                updateTableHistoryLearning(StudentService.getHistoryLearning(pathHistoryLeaningDataFile, idStudent));
            } else
            {

            }
        }

        private void updateDisplayInfoStudent(Student student)
        {
            txtMaSinhVien.Text = student.idStudent;
            txtHoVaTen.Text = student.firstName + " " + student.lastName;
            txtQueQuan.Text = student.placeOfBirth;
            datNgaySinh.Value = student.dateOfBirth;
            cbGioiTinh.Checked = student.gender == Model.GENDER.Male;
        }

        private void updateTableHistoryLearning(List<HistoryLearning> histories)
        {
            if (histories != null)
            {
                bdsQuaTrinhHocTap.DataSource = histories;
            }
            dtgQuaTrinhHocTap.DataSource = bdsQuaTrinhHocTap;
            if (histories == null)
            {
                toolStripStatusTotalHistoryLearning.Text = "Tổng số mục: 0";
            }
            else
            {
                toolStripStatusTotalHistoryLearning.Text = "Tổng số mục: " + histories.Count.ToString();
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            var f = new frmHistoryLearningDetail(pathHistoryLeaningDataFile, idStudent);
            if (f.ShowDialog() == DialogResult.OK)
            {
                // Tiến hành nạp lại dữ liệu
                updateTableHistoryLearning(StudentService.getHistoryLearning(pathHistoryLeaningDataFile, idStudent));
            }
        }

        private void BtnBoQua_Click(object sender, EventArgs e)
        {

        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            var history = bdsQuaTrinhHocTap.Current as HistoryLearning;
            if (history != null)
            {
                var f = new frmHistoryLearningDetail(pathHistoryLeaningDataFile, idStudent, history);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    // Tiến hành nạp lại dữ liệu
                    updateTableHistoryLearning(StudentService.getHistoryLearning(pathHistoryLeaningDataFile, idStudent));
                }
            }
        }
    }
}
