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
- generatedShapeData
- colorData
- size
- mass
- connectionPoints
- physicsValues

Part types for MVP:

- head
- body
- leftUpperArm
- leftLowerArm
- leftHand
- rightUpperArm
- rightLowerArm
- rightHand
- leftUpperLeg
- leftLowerLeg
- leftFoot
- rightUpperLeg
- rightLowerLeg
- rightFoot

## DrawingPhysicsValues

Represents values generated from drawing data.

Fields:

- boundingWidth
- boundingHeight
- filledArea
- aspectRatio
- estimatedCenterOfMass
- normalizedLength
- normalizedWidth
- massMultiplier
- reachMultiplier
- stabilityMultiplier
- wobbleMultiplier
- attackPowerMultiplier
- movementSpeedMultiplier

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

## Online Battle Data

Online battle remains planned.

Online battle may require temporary transfer of character data inside a match.

This is allowed as battle data exchange, not as a public sharing feature.

Possible fields for future online battle:

- playerId
- roomId
- matchId
- selectedCharacterSnapshot
- commandSetup
- battleSettings
- connectionStatus

## Postponed Sharing Data

The following are postponed and should not be prioritized:

- public character gallery
- permanent shared character uploads
- share codes
- user-facing export/import
- browsing other players' characters

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

- cloud save if needed
- account system if needed for online battle or purchases
- online battle service

Postponed:

- character sharing server

## Open Questions

- Should drawingData be stored as strokes, textures, meshes, or a combination?
- Should generated physics values be recalculated every time or saved?
- How small must character data be for online battle transfer?
