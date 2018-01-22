using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ffn_site.Models.Dal
{
    public class ClubDal : IDal<Club>
    {

        private ffn_siteEntities bdd;

        public ClubDal()
        {
            bdd = new ffn_siteEntities();
        }

        public int Add(Club o)
        {
            bdd.Club.Add(o);
            return bdd.SaveChanges();
        }

        public int Delete(Club o)
        {
            bdd.Club.Remove(o);
            return bdd.SaveChanges();
        }

        public int Delete(int id)
        {
            bdd.Club.Remove(Get(id));
            return bdd.SaveChanges();
        }

        public void Dispose()
        {
            bdd.Dispose();
        }

        public Club Get(int id)
        {
            return bdd.Club.Where(c => c.id == id).FirstOrDefault();
        }

        public Club Get(Club o)
        {
            return Get(o.id);
        }

        public List<Club> GetAll()
        {
            return bdd.Club.ToList();
        }

        public int Update(Club o)
        {
            Club club = Get(o.id);
            if (club == null)
                return -1;
            else
            {
                if (o.nomClub != null && !"".Equals(o.nomClub)) club.nomClub = o.nomClub;
                if (o.adresseSiege != null && !"".Equals(o.adresseSiege)) club.adresseSiege = o.adresseSiege;
                if (o.cpSiege != null && !"".Equals(o.cpSiege)) club.cpSiege = o.cpSiege;
                if (o.villeSiege != null && !"".Equals(o.villeSiege)) club.villeSiege = o.villeSiege;
                if (o.siteWeb != null && !"".Equals(o.siteWeb)) club.siteWeb = o.siteWeb;
                return bdd.SaveChanges();
            }
        }

        public int EntityExist(Club o)
        {
            Club club = bdd.Club
                .Where(c => c.idFederal == o.idFederal)
                .FirstOrDefault();
            return (club == null) ? -1 : club.id;
        }
    }
}