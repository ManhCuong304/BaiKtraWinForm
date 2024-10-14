using KTra.CSDL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTra
{
    public partial class Form1 : Form
    {
        Model1 model = new Model1();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "DANH SÁCH SINH VIÊN";
            List<Sinhvien> SinhVien = model.Sinhviens.ToList();
            dataGridView1.Rows.Clear();


            foreach (var item in SinhVien)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = item.MaSV;
                dataGridView1.Rows[index].Cells[1].Value = item.HoTenSV;
                dataGridView1.Rows[index].Cells[2].Value = item.NgaySinh;
                dataGridView1.Rows[index].Cells[3].Value = item.Lop.TenLop;
            }
            List<Lop> Lophoc = model.Lops.ToList();
            cmbLop.DisplayMember = "TenLop";
            cmbLop.ValueMember = "MaLop";
            cmbLop.DataSource = Lophoc;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMsv.Text) || string.IsNullOrWhiteSpace(txtTen.Text) || cmbLop.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string maLop = cmbLop.SelectedValue.ToString();
            Lop selectedLop = model.Lops.FirstOrDefault(l => l.MaLop == maLop);
            Sinhvien newStudent = new Sinhvien
            {
                MaSV = txtMsv.Text,
                HoTenSV = txtTen.Text,
                NgaySinh = datetimesv.Value,
                Lop = selectedLop
            };

            model.Sinhviens.Add(newStudent);
            model.SaveChanges();

            Form1_Load(sender, e);
            MessageBox.Show("Thêm sinh viên thành công!", "Thông báo");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                txtMsv.Text = selectedRow.Cells[0].Value.ToString();
                txtTen.Text = selectedRow.Cells[1].Value.ToString();
                datetimesv.Value = Convert.ToDateTime(selectedRow.Cells[2].Value);
                string tenLop = selectedRow.Cells[3].Value.ToString();
                cmbLop.SelectedIndex = cmbLop.FindStringExact(tenLop);
            }
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            string TenSV = txtTim.Text.Trim().ToLower();

            List<Sinhvien> ketQuaTimKiem = model.Sinhviens.Where(sv => sv.HoTenSV.ToLower().Contains(TenSV)).ToList();

            dataGridView1.Rows.Clear();
            foreach (var item in ketQuaTimKiem)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = item.MaSV;
                dataGridView1.Rows[index].Cells[1].Value = item.HoTenSV;
                dataGridView1.Rows[index].Cells[2].Value = item.NgaySinh;
                dataGridView1.Rows[index].Cells[3].Value = item.Lop.TenLop;
            }

            if (ketQuaTimKiem.Count == 0)
            {
                MessageBox.Show("Không tìm thấy sinh viên nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string Masv = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                Sinhvien editsinhvien = model.Sinhviens.FirstOrDefault(s => s.MaSV == Masv);
                if (editsinhvien != null)
                {
                    editsinhvien.HoTenSV = txtTen.Text;
                    editsinhvien.NgaySinh = datetimesv.Value;
                    string maLop = cmbLop.SelectedValue.ToString();
                    Lop newLop = model.Lops.FirstOrDefault(l => l.MaLop == maLop);
                    if (newLop != null)
                    {
                        editsinhvien.Lop = newLop;
                    }

                    model.SaveChanges();

                    Form1_Load(sender, e);

                    MessageBox.Show("Cập nhật sinh viên thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Sinh viên không tồn tại!", "Thông báo", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn một sinh viên để sửa.", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string maSV = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                Sinhvien DeleSV = model.Sinhviens.FirstOrDefault(s => s.MaSV == maSV);

                if (DeleSV != null)
                {
                    var result = MessageBox.Show("Bạn có chắc muốn xóa sinh viên này không?", "Thông báo", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        model.Sinhviens.Remove(DeleSV);
                        model.SaveChanges();

                        Form1_Load(sender, e);
                        MessageBox.Show("Xóa sinh viên thành công!", "Thông báo");
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn một sinh viên để xóa.", "Thông báo");
            }
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
