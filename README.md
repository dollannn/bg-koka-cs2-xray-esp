## Cheat ESP

Simple cheat ESP plugin for Counter-Strike 2 using CounterStrikeSharp.

## Version
1.0.0

## Authors
AquaVadis & dollan

## Description
This plugin provides wallhack/ESP functionality for admins in CS2. It uses code borrowed from CS2Fixes, cs2kz-metamod, hl2sdk, unknown cheats, and xstage from CS# discord.

## Installation
Install like any other CounterStrikeSharp plugin:
1. Place the plugin files in your CounterStrikeSharp plugins directory
2. Restart your server or load the plugin

## Commands
- `css_wallhacks` - Toggle ESP functionality (admin only)

## Configuration (`counterstrikesharp/configs/plugins/CheatESP` and auto-generated)
- "chat_prefix" - The chat prefix that will appear when using the plugin's commands (default: "{RED}[ESP]")
- "admin_flag" - Permission flag required to use the ESP functionality (default: "@css/root")
- "hide_from_spectator_list" - Whether to hide the admin using ESP from a cheat's spectator list (tested on neverlose)

## Features
- Allows admins to see players through walls
- Hides admins from cheat spectator lists
- Automatically handles player spawns, deaths, and disconnects
- Different colors for T and CT players (Orange for T, SkyBlue for CT)
