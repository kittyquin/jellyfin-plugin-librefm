namespace Jellyfin.Plugin.Lastfm.Resources
{
    public static class Strings
    {
        public static class Endpoints
        {
            public static string LastfmApi = "libre.fm";
        }

        public static class Methods
        {
            // Libre.fm-compatible API specs
            public static string Scrobble = "track.scrobble";
            public static string NowPlaying = "track.updateNowPlaying";
            public static string GetMobileSession = "auth.getMobileSession";
            public static string TrackLove = "track.love";
            public static string TrackUnlove = "track.unlove";
            public static string GetLovedTracks = "user.getLovedTracks";
            public static string GetTracks = "library.getTracks";
        }

        public static class Keys
        {
            public static string LastfmApiKey = "2be5fb432d4c1264a28b568d3c5d6d60";
            public static string LastfmApiSecret = "f77a00c4a2cc6f87acde55570b890827";
        }
    }
}
