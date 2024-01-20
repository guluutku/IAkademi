using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using iakademi38_proje.Models;
using Microsoft.AspNetCore.Mvc;

namespace iakademi38_proje.ViewComponents
{
    public class Telephone : ViewComponent
    {

        iakademi38Context context = new iakademi38Context();

        public string Invoke()
        {
            string telephone = context.Settings.FirstOrDefault(s => s.SettingID == 1)!.Telephone!;
            return $"+90 {telephone}";
        }

    }
}
