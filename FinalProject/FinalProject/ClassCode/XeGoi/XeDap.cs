using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Data;

namespace FinalProject
{
    class XeDap
    {
        MY_DB mydb = new MY_DB();
        SqlCommand command;
        int phiGuiXe1h { get; set; }
        public void PhiGuiXe1H(int phi)
        {
            this.phiGuiXe1h = phi;
        }

        public bool ThemXe(string id, string nguoiGoi, string hinhThucGoi, DateTime ngayGoi, MemoryStream picXe, MemoryStream picGoi)
        {
            DateTime ngayNhan = NgayToiHan(hinhThucGoi, ngayGoi);
            command = new SqlCommand("insert into XeDap (MaXe,NguoiGoi,HinhThucGoi,NgayGoi,NgayToiHan,AnhXe,AnhNguoiGoi)" +
                "values(@id, @name, @hinhthuc, @ngoi, @nnhan, @pcxe, @pcn)", mydb.getConnection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@name", nguoiGoi);
            command.Parameters.AddWithValue("@hinhthuc", hinhThucGoi);
            command.Parameters.AddWithValue("@ngoi", ngayGoi);
            command.Parameters.AddWithValue("@nnhan", ngayNhan);
            command.Parameters.Add("@pcxe", SqlDbType.Image).Value = picXe.ToArray();
            command.Parameters.Add("@pcn", SqlDbType.Image).Value = picGoi.ToArray();
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
        public bool SuaXe(string id, string nguoiGoi, string hinhThucGoi, DateTime ngayGoi, MemoryStream picXe, MemoryStream picGoi)
        {
            DateTime ngayNhan = NgayToiHan(hinhThucGoi, ngayGoi);

            command = new SqlCommand("update XeDap set NguoiGoi=@name,HinhThucGoi=@hinhthuc,NgayGoi=@ngoi,NgayToiHan=@nnhan,AnhXe=@pcxe,AnhNguoiGoi=@pcn where MaXe=@id", mydb.getConnection);

            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@name", nguoiGoi);
            command.Parameters.AddWithValue("@hinhthuc", hinhThucGoi);
            command.Parameters.AddWithValue("@ngoi", ngayGoi);
            command.Parameters.AddWithValue("@nnhan", ngayNhan);
            command.Parameters.AddWithValue("@pcxe", picXe);
            command.Parameters.AddWithValue("@pcn", picGoi);
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
            command = new SqlCommand("DELETE FROM XeDap WHERE MaXe=@id", mydb.getConnection);
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
