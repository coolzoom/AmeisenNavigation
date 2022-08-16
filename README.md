# AmeisenNavigation
Navigation Tcp-Server for my WoW-Bot based on the *TrinityCore MMAP's* and *Recast & Detour*

See this for the Navigation used in the AmeisenBotX: https://www.youtube.com/channel/UCxwiiRjjQVETtatGzKAoIcQ

## How to
- Build with vs2019 x86, may need to copy msvcp140d.dll ucrtbased.dll vcruntime140d.dll from VS2019 x86 folder
- Start from command line, use ```AmeisenNavigationServer.exe config.cfg``` to read the config file path
- config.cfg the ip address remains at 127.0.0.1
- config.cfg the ip address remains at 0.0.0.0 for public access
- config iMaxPolyPath=1024 for enough path points

See this thread on the forum: https://ameisenbotx.de/Thread-How-to-run-the-server

## Credits

❤️ TrinityCore for their MMAP format - https://github.com/TrinityCore/TrinityCore

❤️ Recast & Detour - https://github.com/recastnavigation/recastnavigation
