﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DO_AN_1.Presenation
{
    class DANGNHAP
    {
        GD gd = new GD(100, 45);
        public void start()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Blue;
            gd.pain("╔", 0, 0);
            gd.pain("╚", 0, 45);
            gd.pain("╗",99,0);
            gd.pain("╝",99,45);
            gd.pain("══════════════════════════════════════════════════════════════════════════════════════════════════", 1,0);
            gd.pain("══════════════════════════════════════════════════════════════════════════════════════════════════",1,45);
            for (int i = 1; i <45; ++i)
            {
                gd.pain("║", 0,i);
                gd.pain("║", 99, i);
            }
            Console.ForegroundColor = ConsoleColor.Red;
            gd.pain("CHUONG TRINH QUAN LI KI TUC XA TRUONG DAI HOC SPKT HY", 22, 1);
            gd.pain("KÍ TÚC XÁ", 44, 24);
            gd.pain("TRƯỜNG ĐẠI HỌC SƯ PHAM KĨ THUẬT HƯNG YÊN", 30, 25);
            gd.pain("GIẢNG VIÊN HƯỚNG DẪN                     THẦY NGUYỄN VĂN QUYẾT", 15, 28);
            gd.pain("SINH VIÊN THỰC HIỆN                      NGUYỄN CHÍ MẠNH", 15, 31);
            gd.pain("LỚP                                      101191", 15, 34);
            gd.pain("MÃ SINH VIÊN                             10119539", 15, 37);
            gd.pain("NGÀNH                                    CÔNG NGHỆ PHẦN MỀM", 15, 40);
            gd.pain("      ******   *****      **    **********   *********         ", 20, 15);
            gd.pain("   **          **  **     **        **           **            ", 20, 16);
            gd.pain("  **           **   **    **        **           **            ", 20, 17);
            gd.pain("  **           **    **   **        **           **            ", 20, 18);
            gd.pain(" ***           **     **  **        **           **            ", 20, 19);
            gd.pain("  **           **      ** **        **           **            ", 20, 20);
            gd.pain("   **          **       ****        **           **            ", 20, 21);
            gd.pain("     *******   **        ***        **           **            ", 20, 22);
            gd.pain("  NHẤN PHÍM BẤT KÌ ĐỂ VÀO GIAO DIỆN ĐĂNG NHẬP....PRESS ANY KEY!      ", 17, 44);



            Console.ForegroundColor = ConsoleColor.Blue;
            gd.pain("══════════════════════════════════════════════════════════════════════════════════════════════════", 1, 2);
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 15; i < 45; ++i)
            {
                gd.pain("****", 3, i);
                gd.pain("****", 93, i);
            }
            gd.pain("══════════════════════════════════════════════════════════════════════════════════════════════════", 1, 2);
            gd.pain("══════════════════════════════════════════════════════════════════════════════════════════════════", 1, 2);
            gd.pain("  *******              *****                   ***           ****         **   *****       ", 7, 5);
            gd.pain("  **      **        **       **               **  **         **  **       **    ***        ", 7, 6);
            gd.pain("  **       **      **          **            **    **        **    **     **    ***        ", 7, 7);
            gd.pain("  **        **    **           **           **********       **     **    **    ***        ", 7, 8);
            gd.pain(" ****       **    **           **          ************      **      **   **    ***        ", 7, 9);
            gd.pain("  **      **      **           **         **          **     **       **  **    ***        ", 7,10);
            gd.pain("  **     **        **         **         **            **    **         ****    ***        ", 7, 11);
            gd.pain("  ******               *****            **              **   **          ***   *****        ", 7, 12);
            gd.pain("══════╦════════════════════════════════════════════════════════════════════════════════════╦══════", 1,14);
            

            for (int i = 15; i < 45; ++i)
            {
                gd.pain("║", 7, i);
                gd.pain("║", 92, i);
            }
            
            gd.pain("╠════════════════════════════════════════════════════════════════════════════════════╣", 7, 23);
            gd.pain("╠═══════════════════════════════╦════════════════════════════════════════════════════╣", 7, 26);
            gd.pain("╠═══════════════════════════════╦════════════════════════════════════════════════════╣", 7, 29);
            gd.pain("╠═══════════════════════════════╦════════════════════════════════════════════════════╣", 7, 32);
            gd.pain("╠═══════════════════════════════╦════════════════════════════════════════════════════╣", 7, 35);
            gd.pain("╠═══════════════════════════════╦════════════════════════════════════════════════════╣", 7, 38);
            for (int i = 27; i < 41; ++i)
            {
                gd.pain("║", 39, i);
            
            }
            gd.pain("╠═══════════════════════════════╩════════════════════════════════════════════════════╣", 7,41);

            ConsoleKeyInfo kt = Console.ReadKey();
            switch (kt.Key) 
            {
                case ConsoleKey.Enter:Console.Clear();dangnhap(); break;
                default:
                    return;
            }
        }
        public void dangnhap()
        {
            gd.pain("══════════════════════════════════════════════════════════════════════════════════════════════════", 1, 0);
            gd.pain("══════════════════════════════════════════════════════════════════════════════════════════════════", 1,45);
            for (int i = 1; i < 45; ++i)
            {
                gd.pain("║", 0, i);
                gd.pain("║", 99, i);
            }
           
            gd.pain("╔", 0, 0);
            gd.pain("╚", 0, 45);
            gd.pain("╗", 99, 0);
            gd.pain("╝", 99, 45);
            gd.pain("═══════════════════════════════╦════════════════════════════════════", 14,15);
            for (int i = 16; i < 30; ++i)
            {
                gd.pain("║", 45, i);
            }
            gd.pain("════════════════════════════════════════════════════════════════════", 14, 22);
            for (int i = 16; i <30 ; ++i)
            {
                gd.pain("║", 13, i);
                gd.pain("║", 82, i);
            }
            gd.pain("═══════════════════════════════╩════════════════════════════════════", 14, 30);
            gd.pain("TÀI KHOẢN", 16, 19);
            gd.pain("MẬT KHẨU", 16, 28);
            gd.pain("╔", 13, 15);
            gd.pain("╚", 13, 30);
            gd.pain("╗", 82,15);
            gd.pain("╝", 82,30);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            for (int i =1; i < 45; ++i)
            {
                gd.pain("************", 1, i);
                gd.pain("***************", 83, i);
            }
            for (int i = 1; i <15; ++i)
            {
                gd.pain("**********************************************************************************", 13,i);
            }
            for (int i = 31; i <45; ++i)
            {
                gd.pain("**********************************************************************************", 13, i);
            }
        }
    }
}
