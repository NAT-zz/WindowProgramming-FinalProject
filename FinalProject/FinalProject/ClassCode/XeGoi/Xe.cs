using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    interface IXe
    {
        //int choTrong { get; set; }
        //int phiGoiXe { get; set; }

        bool ThemXe();
    }
    interface IXe1
    {
        bool SuaXe();
        bool XoaXe();
        void XemDanhSach();

        int PhiGoiTheoGio();
        int PhiGoiTheoNgay();
        int PhiGoiTheoTuan();
        int PhiGoiTheoThang();

        int MucPhatTheoGio();
        int MucPhatTheoNgay();
        int MucPhatTheoTuan();
        int MucPhatTheoThang();


    }
}
