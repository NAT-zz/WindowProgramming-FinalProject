using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;

namespace FinalProject.ClassCode.XeGoi
{
    class XeMay
    {
        MY_DB mydb = new MY_DB();
        SqlCommand command;
        int phiGuiXe1h { get; set; }
        public void PhiGuiXe1H(int phi)
        {
            this.phiGuiXe1h = phi;
        }

        public bool ThemXe(string id, string nguoiGoi, string hinhThucGoi, DateTime ngayGoi, MemoryStream picBangSo, MemoryStream picGoi, string bangSo)
        {
            DateTime ngayNhan = NgayToiHan(hinhThucGoi, ngayGoi);
            command = new SqlCommand("insert into XeMay1 (MaXe,NguoiGoi,HinhThucGoi,NgayGoi,NgayToiHan,AnhBangSo,AnhNguoiGoi,BangSo)" +
                "values(@id,@name,@hinhthuc,@ngoi,@nnhan, @pcbs, @pcn, @bs", mydb.getConnection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@name", nguoiGoi);
            command.Parameters.AddWithValue("@hinhthuc", hinhThucGoi);
            command.Parameters.AddWithValue("@ngoi", ngayGoi);
            command.Parameters.AddWithValue("@nnhan", ngayNhan);
            command.Parameters.AddWithValue("@pcbs", picBangSo);
            command.Parameters.AddWithValue("@pcn", picGoi);
            command.Parameters.AddWithValue("@bs", bangSo);
            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool SuaXe(string id, string nguoiGoi, string hinhThucGoi, DateTime ngayGoi, MemoryStream picBangSo, MemoryStream picGoi, string bangSo)
        {
            DateTime ngayNhan = NgayToiHan(hinhThucGoi, ngayGoi);

            command = new SqlCommand("update XeMay1 set NguoiGoi=@name,HinhThucGoi=@hinhthuc,NgayGoi=@ngoi,NgayToiHan=@nnhan,AnhBangSo=@pcbs,AnhNguoiGoi=@pcn,BangSo=@bs where MaXe=@id", mydb.getConnection);

            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@name", nguoiGoi);
            command.Parameters.AddWithValue("@hinhthuc", hinhThucGoi);
            command.Parameters.AddWithValue("@ngoi", ngayGoi);
            command.Parameters.AddWithValue("@nnhan", ngayNhan);
            command.Parameters.AddWithValue("@pcbs", picBangSo);
            command.Parameters.AddWithValue("@pcn", picGoi);
            command.Parameters.AddWithValue("@bs", bangSo);
            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        public bool XoaXe(string id)
        {
            command = new SqlCommand("DELETE FROM XeMay1 WHERE MaXe=@id", mydb.getConnection);
            command.Parameters.AddWithValue("@id", id);
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        public DateTime NgayToiHan(string hinhThucGoi, DateTime ngayGoi)
        {
            DateTime ngayNhan = ngayGoi.AddHours(24);
            if (hinhThucGoi.Contains("Ngay"))
                ngayNhan = ngayGoi.AddDays(7);
            else
            {
                if (hinhThucGoi.Contains("Tuan"))
                    ngayNhan = ngayGoi.AddDays(10);
                else
                    ngayNhan = ngayGoi.AddMonths(2);
            }
            return ngayNhan;
        }
        public int PhiNgay()
        {
            return this.phiGuiXe1h * 8;
        }

        public int PhiTuan()
        {
            return this.PhiNgay() * 3;
        }
        public int PhiThang()
        {
            return this.PhiThang() * 2;
        }

        public int MucPhatGio()
        {
            return this.PhiNgay() * 2;
        }

        public int MucPhatNgay()
        {
            return this.PhiTuan();
        }
        public int MucPhatTuan()
        {
            return this.PhiThang();
        }
    }
}
