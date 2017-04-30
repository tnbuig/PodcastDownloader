using System;

namespace OG.PD.Client.Entities
{
    public class Episode
    {
        public int EpisodeId { get; set; }

        public int PodcastId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public Uri DownloadUrl { get; set; }

        public bool IsDownloaded { get; set; }

        #region Oevrride

        public override bool Equals(object obj)
        {
            var other = obj as Episode;
            if (other == null)
            {
                return false;
            }

            return Name == other.Name && PodcastId == other.PodcastId && Description == other.Description &&
                   IsDownloaded == other.IsDownloaded && DownloadUrl == other.DownloadUrl && IsDownloaded == other.IsDownloaded;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override string ToString()
        {
            return Name;
        }

        #endregion Oevrride
    }
}