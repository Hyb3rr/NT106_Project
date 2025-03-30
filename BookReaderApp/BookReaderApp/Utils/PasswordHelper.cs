using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using BookReaderApp.Data;
using Sodium;
namespace BookReaderApp.Utils
{
    class PasswordHelper
    {
        public static string HashPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("Password không được để trống.");

            return PasswordHash.ArgonHashString(password, PasswordHash.StrengthArgon.Moderate);
            // Có thể đổi thành .Sensitive nếu muốn bảo mật cao hơn
        }

        public static bool VerifyPassword(string password, string storedHash)
        {
            if (string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(storedHash))
                return false; // Tránh lỗi khi đầu vào null hoặc rỗng

            return PasswordHash.ArgonHashStringVerify(storedHash, password);
        }
    }
}
