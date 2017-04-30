using System;

namespace OG.PD.Client.Entities
{
    public class Podcast
    {
        public int PodcastId { get; set; }

        public string Description { get; set; }

        public string Name { get; set; }

        public Uri RssFeed { get; set; }

        public Uri LogoUrl { get; set; }

        public bool IsSubscribed { get; set; }

        #region Oevrride
        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            var other = obj as Podcast;
            if (other == null)
            {
                return false;
            }

            return Name == other.Name && IsSubscribed == other.IsSubscribed && Description == other.Description;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
        #endregion  
    }
}
