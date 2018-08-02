using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VideoOnDemand.Entities;

namespace VideoOnDemand.Web.Models
{
    public class EpisodioViewModel : Media
    {
        public int? Temporada { get; set; }

        #region Relaciones
        public int? SerieId { get; set; }
        public Serie Serie { get; set; }
        #endregion
    }
}