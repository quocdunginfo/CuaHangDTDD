using CuaHangDTDD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform
{
    class Global
    {
        public static NhanVien _nhanvien = null;
        public static List<String> _permission = new List<String>();
        public static void _reset_permission(LoaiNhanVien obj)
        {
            Global._permission = new List<string>();
            foreach (var item in obj.ds_quyen)
            {
                Global._permission.Add(item.ten);
            }
        }
    }
}
