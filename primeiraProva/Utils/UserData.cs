using primeiraProva.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeiraProva.Utils
{
    public static class UserData
    {
        public static Employee user { get; set; }
        public static Color Red { get; set; } = ColorTranslator.FromHtml("#e2231a");
    }
}
