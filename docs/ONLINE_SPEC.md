# Online Spec

## Purpose

Define the online direction for rakugaking after the user decided to postpone character sharing.

## Current Decision

Character sharing is postponed.

This means the project should not prioritize:

- public character gallery
- character sharing codes
- upload/download character sharing
- export/import as a user-facing feature

## Online Priority

The online priority is battle.

## Online Battle Direction

Online battle remains a product goal.

Recommended staging:

1. Local battle prototype
2. Local saved character battle
3. Friend/private online battle design
4. Random matchmaking design
5. Real-time online battle prototype

## First Online Mode Candidate

The first online mode should probably be private room battle.

Reason:

- easier than full matchmaking
- easier to test
- easier to control scope
- better for friends and families

## Match Types

## Private Room Battle

Player creates a room and another player joins.

Possible room data:

- roomId
- hostPlayerId
- guestPlayerId
- battleSettings
- connectionStatus

## Random Matchmaking

Future mode.

Player enters queue and is matched with another player.

Not part of first online implementation.

## Ranked Battle

Future mode.

Not part of early design.

## Networking Concern

Real-time physics synchronization is difficult.

The project must test whether Unity physics battles can be synchronized reliably enough.

Possible approaches:

- host-authoritative simulation
- server-authoritative simulation
- input/command synchronization
- deterministic simulation attempt

## Recommended First Approach

For early online testing:

- host-authoritative battle
- sync command setup and major state
- avoid ranked/competitive promises

## Character Sharing Distinction

Online battle may still require sending character data to the opponent for the battle session.

This is not the same as a public sharing feature.

Allowed for online battle:

- temporary transfer of battle character data inside a match

Postponed:

- public gallery
- permanent shared character uploads
- share codes
- browsing other players' characters

## Monetization Interaction

Online battle should not become pay-to-win.

Paid content may include cosmetics or extra options, but battle advantage should not depend on payment.

## Out of Scope for First Playable MVP

- real-time online battle implementation
- public character sharing
- ranked mode
- public lobbies
- spectator mode
- tournaments

## Related Docs

- `docs/MVP_SPEC.md`
- `docs/ARCHITECTURE.md`
- `docs/BATTLE_SPEC.md`
