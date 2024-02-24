using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class DANTOC
    {
        private QLNHANSUEntities db = new QLNHANSUEntities();

        public tb_DANTOC getItem(int id)
        {
            return db.tb_DANTOC.FirstOrDefault(item => item.ID == id);
        }
        public List<tb_DANTOC> getList()
        {
            return db.tb_DANTOC.ToList();
        }
        public tb_DANTOC Add(tb_DANTOC dt)
        {
            try
            {
                db.tb_DANTOC.Add(dt);
                db.SaveChanges();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }
        public tb_DANTOC Update(tb_DANTOC dt)
        {
            try
            {
                tb_DANTOC _dt = db.tb_DANTOC.FirstOrDefault(item => item.ID == dt.ID);
                if (_dt != null)
                {
                    _dt.TENDT = dt.TENDT;
                    db.SaveChanges();
                    return dt;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }
        public void Delete(int id)
        {
            try
            {
                tb_DANTOC _dt = db.tb_DANTOC.FirstOrDefault(item => item.ID == id);
                if (_dt != null)
                {
                    db.tb_DANTOC.Remove(_dt);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }
    }
}
