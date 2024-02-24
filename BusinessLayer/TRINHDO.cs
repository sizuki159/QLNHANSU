using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class TRINHDO
    {
        private QLNHANSUEntities db = new QLNHANSUEntities();
        public List<tb_TRINHDO> getList()
        {
            return db.tb_TRINHDO.ToList();
        }
        public tb_TRINHDO getItem(int id)
        {
            return db.tb_TRINHDO.FirstOrDefault(item => item.IDTD == id);
        }
        public tb_TRINHDO Add(tb_TRINHDO td)
        {
            try
            {
                db.tb_TRINHDO.Add(td);
                db.SaveChanges();
                return td;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }
        public tb_TRINHDO Update(tb_TRINHDO td)
        {
            try
            {
                tb_TRINHDO _td = db.tb_TRINHDO.FirstOrDefault(item => item.IDTD == td.IDTD);
                if (_td != null)
                {
                    _td.TENTD = td.TENTD;
                    db.SaveChanges();
                    return td;
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
                tb_TRINHDO _td = db.tb_TRINHDO.FirstOrDefault(item => item.IDTD == id);
                if (_td != null)
                {
                    db.tb_TRINHDO.Remove(_td);
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
