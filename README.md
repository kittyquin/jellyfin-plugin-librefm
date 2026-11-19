## jellyfin-plugin-librefm

Enables music scrobbling to Libre.fm, using Libre.fm's Audioscrobbler-compatible API.

This fork of the Jellyfin Last.fm plugin defaults to Libre.fm and uses a Libre.fm API key and secret.

## 🔧 Installation and Configuration

### Requirements

The current plugin release supports **Jellyfin 10.11.9 or newer (including Jellyfin 12)**.

### Installing

Add this repository URL in the Jellyfin Dashboard under Plugins:

- **Repo name:** Libre.fm Stable
- **Repo URL:** https://raw.githubusercontent.com/kittyquin/jellyfin-plugin-librefm/refs/heads/master/manifest.json

Restart Jellyfin after installation, then open the Libre.fm plugin configuration for each Jellyfin user and enter the Libre.fm username and password once. The password is not stored; a session key is saved for future scrobbling.

The API host defaults to `libre.fm`. To keep the fork Libre.fm-only, do not change it.
