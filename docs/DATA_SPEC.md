# Data Spec

## Purpose

Define the minimum data needed for rakugaking.

## Core Data Models

## Character

Represents one player-created fighter.

Fields:

- id
- name
- createdAt
- updatedAt
- bodyType
- parts
- commands
- physicsSettings
- thumbnail

## CharacterPart

Represents one drawn body part.

Fields:

- id
- partType
- drawingData
- meshData or generatedShapeData
- colorData
- size
- mass
- connectionPoints

Part types for MVP:

- head
- body
- leftArm
- rightArm
- leftHand
- rightHand
- leftLeg
- rightLeg
- leftFoot
- rightFoot

## CommandAssignment

Represents a simple behavior assigned to a body part.

Fields:

- partId
- commandType
- strength
- speed
- repeatInterval

Command types for MVP:

- punch
- swing
- guard
- kick
- jump
- crouch

## Battle

Represents one battle session.

Fields:

- id
- characterAId
- characterBId
- mode
- startedAt
- endedAt
- result

## BattleResult

Fields:

- winnerCharacterId
- loserCharacterId
- draw
- reason
- duration

Possible reasons:

- hpZero
- ringOut
- timeUp
- physicsStop

## Sharing Data

Character data should be designed so it can later be:

- exported
- imported
- uploaded
- downloaded
- used in online battle

## Monetization Data

Future monetization may need:

- ownedContentIds
- unlockedBodyTypes
- extraCharacterSlots
- cosmeticInventory

These should not be required for the first playable MVP, but the design should not block them.

## Storage Direction

MVP:

- local save first

Future:

- cloud save
- account system
- character sharing server
- online battle service

## Open Questions

- Should drawingData be stored as strokes, textures, meshes, or a combination?
- Should generated physics values be recalculated every time or saved?
- How small must character data be for online sharing?
