using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace DH52005810
{
    public partial class FrmMain : Form
    {
        private QuanLySP quanLySanPham = new QuanLySP();
        private QuanLyKhachHang quanLyKhachHang = new QuanLyKhachHang();
        private QuanLyHoaDon quanLyHoaDon = new QuanLyHoaDon();
        public FrmMain()
        {
            InitializeComponent();

            quanLySanPham.CreateListSP();
            quanLyKhachHang.CreateListKH();
            quanLyHoaDon.createListHD();
        }

      
      
        // LOAD FORM 
        private void FrmMain_Load(object sender, EventArgs e)
        {
            //Load dgvSanpham
            this.DgvSanPham.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(99, 99, 250);
            this.DgvSanPham.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.DgvSanPham.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 11, FontStyle.Bold);
            this.DgvSanPham.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.DgvSanPham.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(1, 114, 220);

            this.DgvSanPham.EnableHeadersVisualStyles = false;

            DgvSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvSanPham.DefaultCellStyle.ForeColor = Color.DimGray;

            DgvSanPham.RowTemplate.Height = 40;
            this.DgvSanPham.DefaultCellStyle.Font = new Font("Calibri", 10);
            this.DgvSanPham.DefaultCellStyle.SelectionBackColor = Color.FromArgb(231, 231, 255);
            this.DgvSanPham.DefaultCellStyle.SelectionForeColor = Color.Black;
            //load data san pham len dgv 
            txtID.Enabled = true;
            DocFile("data.txt");
            DgvSanPham.Refresh();
            ComboBoxSP.Refresh();
            ComboBoxKH.Refresh();

            //load dgvKhachhang
            this.DgvKhachHang.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(99, 99, 250);
            this.DgvKhachHang.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.DgvKhachHang.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 11, FontStyle.Bold);
            this.DgvKhachHang.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.DgvKhachHang.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(1, 114, 220);

            this.DgvKhachHang.EnableHeadersVisualStyles = false;

            DgvKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvKhachHang.DefaultCellStyle.ForeColor = Color.DimGray;

            DgvKhachHang.RowTemplate.Height = 40;
            this.DgvKhachHang.DefaultCellStyle.Font = new Font("Calibri", 10);
            this.DgvKhachHang.DefaultCellStyle.SelectionBackColor = Color.FromArgb(231, 231, 255);
            this.DgvKhachHang.DefaultCellStyle.SelectionForeColor = Color.Black;

            ReadFile("ListKH.txt");
            DgvKhachHang.Refresh();
            ComboBoxSP.Refresh();
            ComboBoxKH.Refresh();

            //Load dgvbanhang
            this.DgvSale.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(99, 99, 250);
            this.DgvSale.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.DgvSale.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 11, FontStyle.Bold);
            this.DgvSale.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.DgvSale.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(1, 114, 220);

            this.DgvSale.EnableHeadersVisualStyles = false;
            DgvSale.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvSale.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvSale.DefaultCellStyle.ForeColor = Color.DimGray;

            DgvSale.RowTemplate.Height = 40;
            this.DgvSale.DefaultCellStyle.Font = new Font("Calibri", 10);
            this.DgvSale.DefaultCellStyle.SelectionBackColor = Color.FromArgb(231, 231, 255);
            this.DgvSale.DefaultCellStyle.SelectionForeColor = Color.Black;
            ComboData("data.txt");
            ComboBoxSP.Text = "Chọn sản phẩm";
            ComboBoxSP.SelectedItem = null;
            ComboData2("ListKH.txt");
            ComboBoxKH.Text = "Tên Khách hàng";
            ComboBoxKH.SelectedItem = null;
            DgvSale.Refresh();
            ComboBoxSP.Refresh();
            ComboBoxKH.Refresh();

            ComboBoxKH.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxSP.DropDownStyle = ComboBoxStyle.DropDownList;

            //dgvload Hoadon
            this.DgvHoadon.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(99, 99, 250);
            this.DgvHoadon.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.DgvHoadon.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 11, FontStyle.Bold);
            this.DgvHoadon.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.DgvHoadon.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(1, 114, 220);

            this.DgvHoadon.EnableHeadersVisualStyles = false;

            DgvHoadon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvHoadon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvHoadon.DefaultCellStyle.ForeColor = Color.DimGray;

            DgvHoadon.RowTemplate.Height = 40;
            this.DgvHoadon.DefaultCellStyle.Font = new Font("Calibri", 10);
            this.DgvHoadon.DefaultCellStyle.SelectionBackColor = Color.FromArgb(231, 231, 255);
            this.DgvHoadon.DefaultCellStyle.SelectionForeColor = Color.Black;
            DocHoaDonFile("hoadon.txt");
            DgvHoadon.Refresh();

            //dgv Thongke load
            this.DgvThongKe.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(99, 99, 250);
            this.DgvThongKe.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.DgvThongKe.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 11, FontStyle.Bold);
            this.DgvThongKe.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.DgvThongKe.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(1, 114, 220);

            this.DgvThongKe.EnableHeadersVisualStyles = false;

            DgvThongKe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvThongKe.DefaultCellStyle.ForeColor = Color.DimGray;

            DgvThongKe.RowTemplate.Height = 40;
            this.DgvThongKe.DefaultCellStyle.Font = new Font("Calibri", 10);
            this.DgvThongKe.DefaultCellStyle.SelectionBackColor = Color.FromArgb(231, 231, 255);
            this.DgvThongKe.DefaultCellStyle.SelectionForeColor = Color.Black;

            DgvThongKe.Refresh();
            //sale

            dtpNgayBan.Enabled = false;

            //
            
        }

       

        private void ClearText()
        {
            txtID.Text = "";
            txtTenSp.Text = "";
            txtSoLuong.Text = "";
            txtGiaBan.Text = "";
            txtGiaNhap.Text = "";
            dtpNgayNhap.Value = DateTime.Now;
        }
        private bool CheckTrung(string temp)
        {

            for (int i = 0; i < DgvSale.Rows.Count; i++)
            {
                string Id = Convert.ToString(DgvSale[0, i].Value);

                if (temp == Id)
                {
                    MessageBox.Show("Sản phẩm này đã tồn tại trong danh sách mua hàng." + "\n Vui lòng chọn sản phẩm khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }

        private bool CheckNumberPhone(string s)
        {
            char[] sdtArray = s.ToCharArray();
            long result;
            if (!(long.TryParse(s, out result)))
            {
                MessageBox.Show("Sai dữ liệu số điện thoại." +
                    " Vui lòng nhập lại", "Thông báo");
                txtSdt.Focus();
                return false;
            }
            if (result < 0)
            {
                MessageBox.Show("Sai dữ liệu số điện thoại !",
                    "Thông báo");
                txtSdt.Focus();
                return false;
            }
            if (sdtArray.Length != 10)
            {
                MessageBox.Show("Số điện thoại phải đầy đủ 10 số." +
                    " Vui lòng nhập lại", "Thông báo");
                txtSdt.Focus();
                return false;
            }
            return true;
        }
        private bool CheckNumberPhoneExist(int temp)
        {
            for (int i = 0; i < DgvKhachHang.Rows.Count; i++)
            {
                int sdt = Convert.ToInt32(DgvKhachHang[3, i].Value);

                if (sdt == temp)
                {
                    MessageBox.Show("Khách hàng này đã tồn tại trong danh sách !");
                    return false;
                }
            }
            return true;
        }
        private bool CheckTrungMaKH(string temp)
        {
            for (int i = 0; i < DgvKhachHang.Rows.Count; i++)
            {
                string Id = Convert.ToString(DgvKhachHang[0, i].Value);
                if (temp == Id)
                {
                    MessageBox.Show("Khách hàng này đã tồn tại trong danh sách." +
                        " Vui lòng nhập lại mã khách hàng.");
                    return false;
                }
            }
            return true;
        }
        //------------------------------------------------------SẢN PHẨM----------------------------------------------//
        private void DataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvSanPham.SelectedCells.Count > 0)
            {
                txtID.Text = DgvSanPham.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenSp.Text = DgvSanPham.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSoLuong.Text = DgvSanPham.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpNgayNhap.Text = DgvSanPham.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtGiaNhap.Text = DgvSanPham.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtGiaBan.Text = DgvSanPham.Rows[e.RowIndex].Cells[5].Value.ToString();
                bttnFix.Enabled = true;
            }
        }
        private bool CheckTrungSP(string temp)
        {

            for (int i = 0; i < DgvSanPham.Rows.Count; i++)
            {
                string Id = Convert.ToString(DgvSanPham[1, i].Value);

                if (temp == Id)
                {
                    MessageBox.Show("Sản phẩm này đã tồn tại trong danh sách."
                        + "\n Vui lòng nhập sản phẩm khác.",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }
        private void BttnAdd_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtID.Text)) || (string.IsNullOrEmpty(txtTenSp.Text)) ||
                (string.IsNullOrEmpty(txtSoLuong.Text)) || (string.IsNullOrEmpty(txtGiaNhap.Text) 
                || (string.IsNullOrEmpty(txtGiaBan.Text))))
            {
                MessageBox.Show("Vui lòng điền đủ thông tin", "Thông báo", MessageBoxButtons.OK);
            }
            else if (CheckDate2() == false)
            {
                MessageBox.Show("Ngày nhập không thể quá ngày hiện tại.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    int sl = Convert.ToInt32(txtSoLuong.Text);
                    try
                    {
                        string txt = txtTenSp.Text.Trim().TrimStart().TrimEnd(); 
                        string ID = txtID.Text.Trim().TrimStart().TrimEnd();
                        int Gia = Convert.ToInt32(txtGiaNhap.Text);
                        int Gia2 = Convert.ToInt32(txtGiaBan.Text);
                        if (sl > 0 && Gia > 0 && Gia2 > 0)
                        {
                            if (CheckTrungSP(txt) == true)
                            {
                                DgvSanPham.Rows.Add(ID, txt, txtSoLuong.Text, 
                                    dtpNgayNhap.Text, txtGiaNhap.Text, txtGiaBan.Text);
                                DgvSanPham.Refresh();
                                ComboBoxKH.Refresh();
                                ComboBoxSP.Refresh();
                                MessageBox.Show("Thêm sản phẩm thành công.");
                                ClearText();
                            }
                            else
                            {
                                txtID.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Dữ liệu giá và số lượng phải là số dương (+). Vui lòng nhập lại.");
                        }
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Vui lòng nhập đúng dữ liệu giá", "Thông báo");
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Vui lòng nhập đúng dữ liệu số lượng", "Thông báo");
                }
            }
        }
        private void BttnDel_Click(object sender, EventArgs e)
        {
            if (DgvSanPham.SelectedRows.Count > 0)
            {
                DialogResult kq = MessageBox.Show("Bạn muốn xóa", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (kq == DialogResult.OK)
                {
                    int vitriDel = DgvSanPham.CurrentCell.RowIndex;
                    DgvSanPham.Rows.RemoveAt(vitriDel);
                    DgvSanPham.Refresh();
                    ComboBoxKH.Refresh();
                    ComboBoxSP.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool CheckProduct()
        {
            if (Convert.ToInt32(txtSoLuong.Text) <= 0 
                || Convert.ToInt32(txtGiaNhap.Text) <= 0 
                || Convert.ToInt32(txtGiaBan.Text) <= 0)
            {
                return false;
              
            }
            return true;
        }

        private bool CheckDate2()
        {       
            if (dtpNgayNhap.Value <= DateTime.Now)
            {
                return true;
            }
            return false;
        }


        private void BttnFix_Click(object ssender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtID.Text)) 
                || (string.IsNullOrEmpty(txtTenSp.Text)) 
                || (string.IsNullOrEmpty(txtSoLuong.Text)) 
                || (string.IsNullOrEmpty(txtGiaNhap.Text)
                || (string.IsNullOrEmpty(txtGiaBan.Text))))
            {
                MessageBox.Show("Vui lòng điền đủ thông tin", "Thông báo",
                    MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    int soluong = Convert.ToInt32(txtSoLuong.Text);
                    try
                    {
                        string ID = txtID.Text.Trim().TrimStart().TrimEnd();
                        string txt = txtTenSp.Text.Trim().TrimStart().TrimEnd();
                        int gia = Convert.ToInt32(txtGiaNhap.Text);
                        int gia2 = Convert.ToInt32(txtGiaBan.Text);
                        int vitri = DgvSanPham.CurrentCell.RowIndex;
                        if (DgvSanPham.SelectedCells.Count > 0)
                        {
                            DialogResult kq = MessageBox.Show("Bạn muốn sửa thông tin sản phẩm ?",
                                "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            if (kq == DialogResult.OK)
                            {
                                if (ID != DgvSanPham[0, vitri].Value.ToString())
                                {
                                    ID = DgvSanPham[0, vitri].Value.ToString();
                                    MessageBox.Show("Không thể sửa thông tin ID sản phẩm.", 
                                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                if (CheckProduct()==true )
                                {
                                    if (CheckDate2() == true)
                                    {
                                        for (int i = 0; i < DgvSanPham.Rows.Count; i++)
                                        {
                                            if (txtID.Text != DgvSanPham[0, i].Value.ToString())
                                            {
                                                DgvSanPham[1, vitri].Value = txt;
                                                DgvSanPham[2, vitri].Value = txtSoLuong.Text;
                                                DgvSanPham[4, vitri].Value = txtGiaNhap.Text;
                                                DgvSanPham[3, vitri].Value = dtpNgayNhap.Text;
                                                DgvSanPham[5, vitri].Value = txtGiaBan.Text;                                         
                                                DgvSanPham.Refresh();
                                                ComboBoxKH.Refresh();
                                                ComboBoxSP.Refresh();
                                            }
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Ngày nhập không thể quá ngày hiện tại !",
                                            "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);                                 
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Sai dữ liệu nhập .Vui lòng thử lại !");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng chọn dòng cần sửa.", "Thông báo");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Sai dữ liệu giá.", "Thông báo");
                    }
                }
                catch
                {
                    MessageBox.Show("Sai dữ liệu Số lượng.", "Thông báo");
                }
            }
        }
        private void BttnRESET_Click(object sender, EventArgs e)
        {
            ClearText();
        }
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string s = txtSearch.Text;
            List<Sanpham> result = quanLySanPham.SearchProduct(s);
            DgvSanPham.Rows.Clear();
            foreach (Sanpham value in result)
            {
                string[] rows = { value.ID, value.NAME, value.AMOUNT.ToString(), 
                    value.NGAYNHAP.ToString(), value.GIANHAP.ToString(), 
                    value.GIABAN.ToString() };
                DgvSanPham.Rows.Add(rows);

            }
        }
        private void BttnClear_Click(object sender, EventArgs e)
        {
            txtSearch.ResetText();
            txtSearch.Focus();
        }
        private void AutoSaveSP()
        {
            StreamWriter file = new StreamWriter("data.txt");
            try
            {
                string sline = "";
                for (int i = 0; i < DgvSanPham.Rows.Count; i++)
                {
                    for (int j = 0; j < DgvSanPham.Columns.Count; j++)
                    {
                        sline += DgvSanPham.Rows[i].Cells[j].Value;
                        if (j != DgvSanPham.Columns.Count)
                        {
                            sline += "|";
                        }
                    }
                    file.WriteLine(sline);
                    sline = "";
                }
                file.Close();
                ComboBoxKH.Refresh();
                ComboBoxSP.Refresh();
            }
            catch (System.Exception)
            {
                MessageBox.Show("Lỗi Lưu dữ liệu.  Vui lòng thử lại sau");
                file.Close();
            }
        }
        private void Button1_Click(object sender, EventArgs e) // Export
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn lưu dữ liệu ?", 
                "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (kq == DialogResult.OK)
            {
                
                try
                {
                    StreamWriter file = new StreamWriter("data.txt");
                    string sline = "";
                    for (int i = 0; i < DgvSanPham.Rows.Count; i++)
                    {
                        for (int j = 0; j < DgvSanPham.Columns.Count; j++)
                        {
                            sline += DgvSanPham.Rows[i].Cells[j].Value;
                            if (j != DgvSanPham.Columns.Count)
                            {
                                sline += "|";
                            }
                        }
                        file.WriteLine(sline);
                        sline = "";
                    }
                    file.Close();
                    MessageBox.Show("Lưu Thành công ");
                    ComboBoxSP.Items.Clear();
                    ComboBoxKH.Items.Clear();
                    ComboData("data.txt");
                    ComboData2("ListKH.txt");
                    ComboBoxKH.Refresh();
                    ComboBoxSP.Refresh();
                }
                catch (System.Exception)
                {
                    MessageBox.Show("Lỗi lưu dữ liệu.  Vui lòng thử lại sau");
                    
                }
            }
        }
        private void Button4_Click(object sender, EventArgs e) // Import
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn Refresh dữ liệu  ?",
                "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (kq == DialogResult.OK)
            {
                DgvSanPham.Rows.Clear();


                string[] lines = File.ReadAllLines("data.txt");
                string[] values;


                for (int i = 0; i < lines.Length; i++)
                {
                    values = lines[i].ToString().Split('|');
                    string[] row = new string[values.Length];

                    for (int j = 0; j < values.Length; j++)
                    {
                        row[j] = values[j].Trim();
                    }
                    DgvSanPham.Rows.Add(row);
                   
                }
                MessageBox.Show("Refresh dữ liệu thành công !");
                ComboData("data.txt");
                ComboData2("ListKH.txt");
                ComboBoxKH.Refresh();
                ComboBoxSP.Refresh();
            }
        }
        public void DocFile(string tenfile)
        {
            string[] lines = File.ReadAllLines("data.txt");
            string[] values;


            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split('|');
                string[] row = new string[values.Length];

                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }
                DgvSanPham.Rows.Add(row);
                ComboBoxKH.Refresh();
                ComboBoxSP.Refresh();

            }
        }
        //------------------------------------------------------BÁN HÀNG--------------------------------------------------//
        public enum Gioitinh { Nam, Nu, Khac } 
        List<string> ListItem;
        public void ComboData(string tenfile)
        {
            string[] lines = File.ReadAllLines(@"data.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                string[] value = lines[i].Split('|');
                string name = value[1];
                ComboBoxSP.Items.Add(name);
                ComboBoxSP.Refresh();

            }
        }
        public void ComboData2(string tenfile)
        {
            string[] lines2 = File.ReadAllLines(@"ListKH.txt");
            for (int i = 0; i < lines2.Length; i++)
            {
                string[] value2 = lines2[i].Split('|');
                string name2 = value2[1];
                ComboBoxKH.Items.Add(name2);
                ComboBoxKH.Refresh();

            }
        }
        private void ClearSale()
        {
            ComboBoxSP.SelectedItem = null;
            txtID2.Text = "";
            txtGia.Text = "";
            txtKho.Text = "";
            txtSoLuongSale.Text = "";
        }
        private void BttnHoadon_Click(object sender, EventArgs e)//button them
        {
            if ((string.IsNullOrEmpty(txtID2.Text)) || 
                (string.IsNullOrEmpty(txtSoLuongSale.Text)) || 
                (string.IsNullOrEmpty(txtSdt.Text)))
            {
                MessageBox.Show("Vui lòng điền đủ thông tin", "Thông báo",
                    MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    int sl2 = Convert.ToInt32(txtSoLuongSale.Text);
                    try
                    {
                        if (Convert.ToInt32(txtKho.Text) != 0)
                        {
                            if (sl2 > 0 && sl2 <= Convert.ToInt32(txtKho.Text))
                            {
                                for (int i = 0; i < DgvSanPham.Rows.Count; i++)
                                {
                                    if (txtID2.Text == DgvSanPham[0, i].Value.ToString()
                                        && CheckNumberPhone(txtSdt.Text) && CheckTrung(txtID2.Text))
                                    {
                                        int tien = Convert.ToInt32(DgvSanPham[5, i].Value) * sl2;
                                        int kho = Convert.ToInt32(DgvSanPham[2, i].Value) - sl2;
                                        DgvSanPham[2, i].Value = kho;
                                        DgvSale.Rows.Add(txtID2.Text, ComboBoxSP.Text, sl2, tien,
                                            dtpNgayBan.Text);
                                        ClearSale();
                                        DgvSale.Refresh();
                                        DgvSanPham.Refresh();
                                        ComboBoxKH.Refresh();
                                        ComboBoxSP.Refresh();
                                        MessageBox.Show("Thêm thông tin thành công.");
                                    }
                                }

                            }
                            else
                            {
                                MessageBox.Show("Sai dữ liệu số lượng mua.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Sản phẩm này đã hết hàng.", "Thông báo");
                        }
                    }
                    catch (Exception)
                    { }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Vui lòng nhập đúng dữ liệu số lượng", "Thông báo");
                }

            }
        }
        private void Bttnxoaban_Click(object sender, EventArgs e)
        {
            if (DgvSale.SelectedRows.Count > 0)
            {
                int vitri = DgvSale.CurrentCell.RowIndex;

                if (txtID2.Text != DgvSale[0, vitri].Value.ToString())
                {
                    MessageBox.Show("Sai dữ liệu bán hàng.Vui lòng nhập lại.",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Convert.ToInt32(txtSoLuongSale.Text) == 
                        Convert.ToInt32(DgvSale[2, vitri].Value))
                    {
                        int kho = Convert.ToInt32(txtKho.Text);
                        try
                        {
                            int sl = Convert.ToInt32(txtSoLuongSale.Text);

                            DialogResult kq = MessageBox.Show("Bạn muốn xóa sản phẩm ",
                                "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                            if (kq == DialogResult.OK)
                            {
                                int vitriDel = DgvSale.CurrentCell.RowIndex;
                                DgvSale.Rows.RemoveAt(vitriDel);
                                kho += sl;
                                txtKho.Text = Convert.ToString(kho);
                                txtSoLuongSale.Text = "";
                                DgvSale.Refresh();

                                for (int i = 0; i < DgvSanPham.Rows.Count; i++)
                                {
                                    if (txtID2.Text == DgvSanPham[0, i].Value.ToString())
                                    {
                                        DgvSanPham[2, i].Value = kho;
                                    }
                                }
                                MessageBox.Show("Xóa thành công.", "Thông báo");

                            }
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Sai dữ liệu số lượng.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa!" + "\nVui lòng Click chọn Thông tin bán hàng cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa.");
            }
        }
        private void BttnSuaban_Click(object sender, EventArgs e)
        {
            if (DgvSale.SelectedCells.Count > 0)
            {
                if ((string.IsNullOrEmpty(txtID2.Text)) || (string.IsNullOrEmpty(txtSoLuongSale.Text)) 
                    || (string.IsNullOrEmpty(txtSdt.Text)))
                {
                    MessageBox.Show("Vui lòng điền đủ thông tin", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    try
                    {
                        int sl2 = Convert.ToInt32(txtSoLuongSale.Text);
                        try
                        {
                            int vitri = DgvSale.CurrentCell.RowIndex;
                            int dongia = Convert.ToInt32(txtGia.Text);
                            int kho2 = Convert.ToInt32(txtKho.Text);
                            int solg2 = Convert.ToInt32(txtSoLuongSale.Text);

                            if (txtID2.Text != DgvSale[0, vitri].Value.ToString())
                            {
                                MessageBox.Show("Sai dữ liệu bán hàng.Vui lòng nhập lại.",
                                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (txtSoLuongSale.Text == DgvSale[2, vitri].Value.ToString() && Convert.ToDateTime(dtpNgayBan.Value) == Convert.ToDateTime(DgvSale[4,vitri].Value))
                            {
                                MessageBox.Show("Không có gì để sửa. Vui lòng nhập lại", 
                                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                DialogResult kq = MessageBox.Show("Bạn muốn sửa thông tin sản phẩm ?",
                                    "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                if (kq == DialogResult.OK)
                                {
                                    //khi sua thi kho se cap nhat so luong
                                    kho2 += (Convert.ToInt32(DgvSale[2, vitri].Value) - solg2);
                                    if (solg2 > 0)
                                    {
                                        if (kho2 >= 0)
                                        {
                                            txtKho.Text = Convert.ToString(kho2);
                                            for (int i = 0; i < DgvSanPham.Rows.Count; i++)
                                            {
                                                if (txtID2.Text == DgvSanPham[0, i].Value.ToString())
                                                {
                                                    DgvSanPham[2, i].Value = kho2;
                                                }

                                                DgvSale[4, vitri].Value = dtpNgayBan.Text;
                                                DgvSale[3, vitri].Value = (sl2 * dongia);
                                                DgvSale[2, vitri].Value = txtSoLuongSale.Text;
                                                DgvSale[1, vitri].Value = ComboBoxSP.Text;
                                                DgvSale[0, vitri].Value = txtID2.Text;
                                                DgvSale.Refresh();
                                            }
                                            MessageBox.Show("Sửa thành công.", "Thông báo", MessageBoxButtons.OK);
                                            txtSoLuongSale.Text = "";
                                            ComboBoxKH.Refresh();
                                            ComboBoxSP.Refresh();
                                        }
                                        else
                                        {
                                            txtSoLuongSale.Text = "";
                                            MessageBox.Show("Không đủ số lượng cung cấp.");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Số lượng mua phải lớn hơn 1 sản phẩm.");
                                        txtSoLuongSale.Text = "";
                                    }
                                }
                            }
                        }
                        catch (Exception)
                        { }
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Sai dữ liệu số lượng mua.", "Thông báo");
                        txtSoLuongSale.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa.", "Thông báo");
            }
        }
        private void ClearSP()
        {
            txtID2.ResetText();
            txtGia.ResetText();
            txtKho.ResetText();
        }
        private void BttnHuynhap_Click(object sender, EventArgs e)
        {
            if (ComboBoxSP.SelectedItem != null)
            {
                ComboBoxSP.Text = "Chọn sản phẩm";
                ClearSP();
                ComboBoxSP.Refresh();
                ComboBoxSP.SelectedItem = null;

                MessageBox.Show("Đã hủy chọn sản phẩm.", "Thông báo");
                ComboBoxSP.Focus();

            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm.", "Thông báo", MessageBoxButtons.OK);
            }
        }
        private void ComboBox1_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < DgvSanPham.Rows.Count; i++)
            {
                
                ListItem = new List<string> { DgvSanPham[1, i].Value.ToString() };
                if(ComboBoxSP.Text == DgvSanPham[1, i].Value.ToString())
                {
                    txtID2.Text = DgvSanPham[0, i].Value.ToString();
                    txtKho.Text = DgvSanPham[2, i].Value.ToString();
                    txtGia.Text = DgvSanPham[5, i].Value.ToString();
                }
                
                
            }

        }
        private void ComboBoxKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < DgvKhachHang.Rows.Count; i++)
            {
                ListItem = new List<string> { DgvKhachHang[1, i].Value.ToString() };
                if (ComboBoxKH.Text == DgvKhachHang[1, i].Value.ToString())
                {
                    txtSdt.Text = DgvKhachHang[3, i].Value.ToString();
                    if (DgvKhachHang[2, i].Value.ToString() == "Nữ")
                        radNu.Checked = true;
                    if (DgvKhachHang[2, i].Value.ToString() == "Nam")
                        radNam.Checked = true;
                }
            }
        }
         

        private void DgvSale_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvSale.SelectedCells.Count > 0)
            {
                txtID2.Text = DgvSale.Rows[e.RowIndex].Cells[0].Value.ToString();
                ComboBoxSP.Text = DgvSale.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSoLuongSale.Text = DgvSale.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpNgayBan.Value = Convert.ToDateTime(DgvSale.Rows[e.RowIndex].Cells[4].Value.ToString());
                bttnSuaban.Enabled = true;
            }
        }

        private void BttnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (DgvSale.Rows.Count > 0)
                {
                    DialogResult kq = MessageBox.Show("Bạn muốn THANH TOÁN và IN HÓA ĐƠN ?",
                        "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (kq == DialogResult.OK)
                    {
                        double tongtien = 0;
                        string sline = "MDH00";
                        for (int i = 0; i < DgvSale.Rows.Count; i++)
                        {
                            tongtien = tongtien + Convert.ToDouble(DgvSale[3, i].Value);
                        }
                        sline += Convert.ToInt32(DgvHoadon.Rows.Count + 1);

                        //madh
                        DgvHoadon.Rows.Add(sline, ComboBoxKH.SelectedItem, txtSdt.Text,
                            Convert.ToDouble(tongtien), 
                            Convert.ToDateTime(dtpNgayBan.Value).ToShortDateString());
                        AutoSave();
                        AutoSaveSP();
                        AutoSaveHD();

                        DgvSale.Rows.Clear();
                        ComboBoxKH.SelectedItem = null;
                        txtSdt.Text = "";
                        DgvHoadon.Refresh();
                        ComboBoxKH.Refresh();
                        ComboBoxSP.Refresh();
                        MessageBox.Show("Thanh toán và in hóa đơn thành công. ");
                        tabSanPham.SelectedIndex = 3; // hien thi hoa tab hoa don
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập thông tin bán hàng trước khi thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (System.Exception)
            {
                MessageBox.Show("Lỗi lưu dữ liệu.  Vui lòng thử lại sau");

            }


        }
     
        private void AutoSave()
        {
            if (DgvSale.Rows.Count > 0)
            {
                StreamWriter file = new StreamWriter("sold.txt");

                try
                {
                    string sline = "";
                    for (int i = 0; i < DgvSale.Rows.Count; i++)
                    {
                        for (int j = 0; j < DgvSale.Columns.Count; j++)
                        {
                            sline += DgvSale.Rows[i].Cells[j].Value;
                            if (j != DgvSale.Columns.Count)
                            {
                                sline += "|";
                            }
                        }
                        file.WriteLine(sline);
                        sline = "";
                    }
                    file.Close();
                    DgvSale.Refresh();
                    ComboBoxKH.Refresh();
                    ComboBoxSP.Refresh();
                }
                catch (System.Exception)
                {
                    MessageBox.Show("Lỗi Lưu dữ liệu.  Vui lòng thử lại sau");
                    file.Close();
                }
            }
        }

        //-----------------------------------------------------KHÁCH HÀNG-------------------------------------------------//
        private void BttnSAveKH_Click(object sender, EventArgs e)
        {

            DialogResult kq = MessageBox.Show("Bạn có muốn lưu dữ liệu ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (kq == DialogResult.OK)
            {
                StreamWriter file = new StreamWriter("ListKH.txt");
                try
                {
                    string sline = "";
                    for (int i = 0; i < DgvKhachHang.Rows.Count; i++)
                    {
                        for (int j = 0; j < DgvKhachHang.Columns.Count; j++)
                        {
                            sline += DgvKhachHang.Rows[i].Cells[j].Value;
                            if (j != DgvKhachHang.Columns.Count)
                            {
                                sline += "|";
                            }
                        }
                        file.WriteLine(sline);
                        sline = "";
                        
                    }                            
                    file.Close();
                    MessageBox.Show("Lưu thành công ");
                    ComboBoxSP.Items.Clear();
                    ComboBoxKH.Items.Clear();
                    ComboData("data.txt");
                    ComboData2("ListKH.txt");
                    DgvKhachHang.Refresh();
                    DgvHoadon.Refresh();
                   
                }
                catch (System.Exception)
                {
                    MessageBox.Show("Lỗi lưu dữ liệu.  Vui lòng thử lại sau");
                    file.Close();
                }
            }
        }

        private void BttnRefreshKH_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn Refresh dữ liệu  ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (kq == DialogResult.OK)
            {
                DgvKhachHang.Rows.Clear();


                string[] lines = File.ReadAllLines("ListKH.txt");
                string[] values;


                for (int i = 0; i < lines.Length; i++)
                {
                    values = lines[i].ToString().Split('|');
                    string[] row = new string[values.Length];

                    for (int j = 0; j < values.Length; j++)
                    {
                        row[j] = values[j].Trim();
                    }
                    DgvKhachHang.Rows.Add(row);   
                }
                MessageBox.Show("Refresh dữ liệu thành công !");
               
                ComboData("data.txt");
                ComboData2("ListKH.txt");
                DgvKhachHang.Refresh();
                ComboBoxKH.Refresh();
                ComboBoxSP.Refresh();
            }
        }
        private void ReadFile(string tenfile)
        {
            DgvKhachHang.Rows.Clear();
            string[] lines = File.ReadAllLines("ListKH.txt");
            string[] values;
            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split('|');
                string[] row = new string[values.Length];

                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }
                DgvKhachHang.Rows.Add(row);
                DgvKhachHang.Refresh();
                ComboBoxKH.Refresh();
                ComboBoxSP.Refresh();
            }
        }
        private void ClearTextKH()
        {
            txtHoTen.Text = "";
            txtMaKH.Text = "";
            txtSdtKH.Text = "";
            txtDiachi.Text = "";
        }
        private void BttnThemKH_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtHoTen.Text)) ||
                (string.IsNullOrEmpty(txtMaKH.Text)) || (string.IsNullOrEmpty(txtSdtKH.Text))
                || (string.IsNullOrEmpty(txtDiachi.Text)))
            {
                MessageBox.Show("Vui lòng điền đủ thông tin", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    string sdt = txtSdtKH.Text.Trim().TrimEnd().TrimStart();
                    string TenKH = txtHoTen.Text.Trim().TrimEnd().TrimStart();
                    string MaKH = txtMaKH.Text.Trim().TrimEnd().TrimStart();
                    if (CheckNumberPhone(sdt))
                    {
                        if (CheckTrungMaKH(MaKH) == true &&
                            CheckNumberPhoneExist(Convert.ToInt32(sdt)))
                        {
                            string loai = " ";
                            if (rdbNuKH.Checked == true)
                                loai = "Nữ";
                            if (rdbNamKH.Checked == true)
                                loai = "Nam";
                            DgvKhachHang.Rows.Add(MaKH, TenKH, loai, sdt, txtDiachi.Text);
                            DgvKhachHang.Refresh();
                            MessageBox.Show("Thêm khách hàng thành công.");

                            //sau khi thêm thông tin thì tất cả các txb thuộc tính cho về rỗng
                            ClearTextKH();
                            DgvKhachHang.Refresh();
                            ComboBoxKH.Refresh();
                            ComboBoxSP.Refresh();
                        }
                    }
                }
                catch (Exception)
                { }
            }
        }
        private void BttnSuaKH_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtMaKH.Text)) || 
                (string.IsNullOrEmpty(txtHoTen.Text)) || 
                (string.IsNullOrEmpty(txtSdtKH.Text))
                || (string.IsNullOrEmpty(txtDiachi.Text)))
            {
                MessageBox.Show("Vui lòng điền đủ thông tin", "Thông báo"
                    , MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    if (DgvKhachHang.SelectedCells.Count > 0)
                    {
                        DialogResult kq = MessageBox.Show("Bạn muốn sửa thông tin khách hàng ?"
                            , "Thông báo", MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Information);
                        if (kq == DialogResult.OK)
                        {
                            string gt1 = "Nam";
                            string gt2 = "Nữ";
                            int vitri = DgvKhachHang.CurrentCell.RowIndex;
                            string TenKH = txtHoTen.Text.Trim().TrimStart().TrimEnd();
                            string MaKH = txtMaKH.Text.Trim().TrimEnd().TrimStart(); ;
                            string sdt = txtSdtKH.Text.Trim().TrimEnd().TrimStart();
                            if (MaKH != DgvKhachHang[0, vitri].Value.ToString())
                            {
                                MessageBox.Show("Không thể sửa thông tin mã khách hàng",
                                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                MaKH = DgvKhachHang[0, vitri].Value.ToString();
                            }
                            else if ( CheckNumberPhone(sdt))
                            {
                                for (int i = 0; i < DgvKhachHang.Rows.Count; i++)
                                {
                                    DgvKhachHang[1, vitri].Value = TenKH;
                                    if (rdbNuKH.Checked == true)
                                        DgvKhachHang[2, vitri].Value = gt2;
                                    if (rdbNamKH.Checked == true)
                                        DgvKhachHang[2, vitri].Value = gt1;
                                    DgvKhachHang[4, vitri].Value = txtDiachi.Text;
                                }

                                if (CheckNumberPhoneExist(Convert.ToInt32(sdt)))
                                {
                                    DgvKhachHang[3, vitri].Value = sdt;
                                }
                            }
                            DgvKhachHang.Refresh();
                            ComboBoxKH.Refresh();
                            ComboBoxSP.Refresh();
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng chọn dòng cần sửa.", "Thông báo");
                        }
                    }
                }
                catch (Exception)
                {
                    return;
                }
            }
        }
        private void BttnXoaKH_Click(object sender, EventArgs e)
        {
            if (DgvKhachHang.SelectedRows.Count > 0)
            {
                DialogResult kq = MessageBox.Show("Bạn muốn xóa", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (kq == DialogResult.OK)
                {
                    int vitriDel = DgvKhachHang.CurrentCell.RowIndex;
                    DgvKhachHang.Rows.RemoveAt(vitriDel);
                    ComboBoxKH.Refresh();
                    ComboBoxSP.Refresh();
                    DgvKhachHang.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa.");
            }
        }
        private void TxtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            DgvKhachHang.Refresh();
            string s = txtSearchCustomer.Text;
            List<KhachHang> result = quanLyKhachHang.SearchWithNumberPhone(s);
            DgvKhachHang.Rows.Clear();
            foreach (KhachHang value in result)
            {
                string[] rows = { value.MaKH, value.HOTEN, value.gioiTinh.ToString(), value.SDT.ToString(), value.DiaChi };
                DgvKhachHang.Rows.Add(rows);
            }
        }
        private void BttnresetSearchCus_Click(object sender, EventArgs e)
        {
            txtSearchCustomer.ResetText();
            txtSearchCustomer.Focus();
        }
        private void DgvKhachHang_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvKhachHang.SelectedCells.Count > 0)
            {
                txtMaKH.Text = DgvKhachHang.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtHoTen.Text = DgvKhachHang.Rows[e.RowIndex].Cells[1].Value.ToString();
                if (DgvKhachHang.Rows[e.RowIndex].Cells[2].Value.ToString() == "Nữ")
                    rdbNuKH.Checked = true;
                if (DgvKhachHang.Rows[e.RowIndex].Cells[2].Value.ToString() == "Nam")
                    rdbNamKH.Checked = true;
                txtSdtKH.Text = DgvKhachHang.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDiachi.Text = DgvKhachHang.Rows[e.RowIndex].Cells[4].Value.ToString();

                bttnSuaKH.Enabled = true;
            }
        }
        //---------------------------------------------------------HÓA ĐƠN---------------------------------------------------//
       
        public void DocHoaDonFile(string tenfile)
        {
            string[] lines = File.ReadAllLines("hoadon.txt");
            string[] values;


            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split('|');
                string[] row = new string[values.Length];

                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }
                DgvHoadon.Rows.Add(row);
                ComboBoxKH.Refresh();
                ComboBoxSP.Refresh();

            }
        }
        private void AutoSaveHD()
        {
            StreamWriter file = new StreamWriter("hoadon.txt");
            try
            {
                string sline = "";
                for (int i = 0; i < DgvHoadon.Rows.Count; i++)
                {
                    for (int j = 0; j < DgvHoadon.Columns.Count; j++)
                    {
                        sline += DgvHoadon.Rows[i].Cells[j].Value;
                        if (j != DgvHoadon.Columns.Count)
                        {
                            sline += "|";
                        }
                    }
                    file.WriteLine(sline);
                    sline = "";
                }
                file.Close();
                DgvHoadon.Refresh();
                ComboBoxKH.Refresh();
                ComboBoxSP.Refresh();
            }
            catch (Exception) { }
        }

        private void TxtSearchHoaDon_TextChanged(object sender, EventArgs e)
        {
            DgvHoadon.Refresh();
            string s = txtSearchHoaDon.Text;
            List<HoaDon> result = quanLyHoaDon.SearchWithNumberHD(s);
            DgvHoadon.Rows.Clear();
            foreach (HoaDon value in result)
            {
                string[] rows = { value.MaDH, value.TenHD, value.SoDT.ToString(), value.TongTien.ToString(), value.NgayMua.ToString() };
                DgvHoadon.Rows.Add(rows);
            }
        }
       
        private void BttnResetHD_Click(object sender, EventArgs e)
        {
            txtSearchHoaDon.ResetText();
            txtSearchHoaDon.Focus();
        }

        //------------------------------------------------------------THỐNG KÊ-------------------------------------------------//

        private void BttnThongke_Click(object sender, EventArgs e)
        {
            if (rdbngay.Checked || rdbThang.Checked || rdbYear.Checked|| rdbAll.Checked)
            {
                DgvThongKe.Rows.Clear();
                double Tong = 0;
                for (int i = 0; i < DgvHoadon.Rows.Count; i++)
                {
                    if (rdbngay.Checked)
                    {
                        if (dtpThongKe.Text == DgvHoadon[4, i].Value.ToString())
                        {
                            DgvThongKe.Rows.Add(DgvHoadon[1, i].Value,DgvHoadon[2, i].Value,
                                Convert.ToDateTime(DgvHoadon[4, i].Value).ToShortDateString(), 
                                DgvHoadon[3, i].Value.ToString());
                        }
                    }
                    if (rdbThang.Checked)
                    {

                        if (numbrMonth.Value == Convert.ToDateTime(DgvHoadon[4, i].Value).Month)
                        {
                            DgvThongKe.Rows.Add(DgvHoadon[1, i].Value, DgvHoadon[2, i].Value,
                                Convert.ToDateTime(DgvHoadon[4, i].Value).ToShortDateString(), DgvHoadon[3, i].Value.ToString());
                        }

                    }

                    if (rdbYear.Checked)
                    {

                        if (numrYear.Value == Convert.ToDateTime(DgvHoadon[4, i].Value).Year)
                        {
                            DgvThongKe.Rows.Add(DgvHoadon[1, i].Value, DgvHoadon[2, i].Value, 
                                Convert.ToDateTime(DgvHoadon[4, i].Value).ToShortDateString(),
                                DgvHoadon[3, i].Value.ToString());
                        }

                    }

                    if (rdbAll.Checked)
                    {
                        DgvThongKe.Rows.Add(DgvHoadon[1, i].Value, DgvHoadon[2, i].Value, 
                            Convert.ToDateTime(DgvHoadon[4, i].Value).ToShortDateString(), DgvHoadon[3, i].Value.ToString());

                    }
                }
                //THONG KE HOA DON va so luong
                for (int j = 0; j < DgvThongKe.Rows.Count; j++)
                {

                    Tong += Convert.ToDouble(DgvThongKe[3, j].Value.ToString());
                }
                txtTongDT.Text = Tong.ToString();
                txtSLHoaDon.Text = DgvThongKe.Rows.Count.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại thống kê.","Thông báo");
            }
        }
        private void BttnHuyTK_Click(object sender, EventArgs e)
        {
            DgvThongKe.Rows.Clear();
            rdbngay.Checked= false;
            rdbThang.Checked = false;
            rdbYear.Checked = false;
            txtTongDT.Text = "";
            txtSLHoaDon.Text = "";

        }
        //------------------------------------------------------------TÀI KHOẢN-------------------------------------------------//
        private void BttnDangxuat_Click(object sender, EventArgs e)
        {
                DialogResult kq = MessageBox.Show("Bạn có muốn đăng xuất ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (kq == DialogResult.OK)
            {
                this.Hide();
                formlogin f = new formlogin();
                f.ShowDialog();
            }         
        }

        private void BttnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình ?", "THÔNG BÁO", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

       
    }
}