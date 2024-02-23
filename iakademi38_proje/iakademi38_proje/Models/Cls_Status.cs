using System;
using Microsoft.EntityFrameworkCore;
using XAct;

namespace iakademi38_proje.Models
{
	public class Cls_Status
	{
        iakademi38Context context = new iakademi38Context();

		public Cls_Status()
		{
		}

        public async Task<List<Status>> StatusSelect()
        {
            List<Status> statuses = await context.Statuses.ToListAsync();
            return statuses;
        }

        public bool StatusInsert(Status status)
        {
            try
            {
                using (iakademi38Context context = new iakademi38Context())
                {
                    context.Add(status);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<Status> StatusDetails(int? id)
        {
            Status? status = await context.Statuses.FirstOrDefaultAsync(s => s.StatusID == id);
            return status;
        }

        public static bool StatusUpdate(Status status)
        {
            try
            {
                using (iakademi38Context context = new iakademi38Context())
                {
                    context.Update(status);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool StatusDelete(int id)
        {
            try
            {
                using (iakademi38Context context = new iakademi38Context())
                {
                    Status status = (Status)context.Statuses.Where(c => c.StatusID == id);
                    status.Active = false;

                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

