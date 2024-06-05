# Audiobookshelf.ApiClient

This is a library created in C# that can connect to the api of an Audiobookshelf-instance.

Read more about Audiobookshelf here: https://www.audiobookshelf.org

## State of the library

Currently this library is in development. While some things is ready to be used, many core features of the Api is still missing, and things might be unstable.

## Features currently implemented

Here comes a list of the main endpoints and other features implemented.

Mark that some endpoints/features might not be mentioned directly, but might still be part of something listed. Mark also that how the api is made, it might happen that most of a feature7endpoint is implemented (and listed), but some small options may still be missing.

### Authentication and server

- Login with username/password.
- Login by giving a valid api token (this will currently only set it, not check if it actally is valid).
- Logout.
- Get server status.
- Ping.
- Healthcheck.

### Libraries

- Create a new library.
- Get all libraries.
- Get a library.
- Update a library.
- Delete a library.
- Get a libraries items (books, podcasts, etc.).
- Remove library iteems in a library that has issues.
- Get podcast-episodes downloads from a podcast library.
- Get a library's series.
- Get a library's collections.
- Get a library's playlists.
- Get a library's personalized view.
- Get a library's filter data.
- Search in the given library.
- Get a library's stats.
- Get a library's authors.
- Match All of a Library's Items.
- Scan a Library's Folders.
- Get a Library's Recent Episodes.
- Reorder Library List.

### Library items

- Delete all library items.
- Get a library item.
- Delete a library item.
- Update a library item's media.
- Get a library item's cover.

## Licenses

Mark that while this ApiClient-library is MIT-licensed, Audiobookshelf itself has it's own license.

Mark also that the creator and maintainer of this library is not involved in creating or maintaining Audiobookshelf itself.
