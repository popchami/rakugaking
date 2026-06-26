# HANDOFF

## Project Name

rakugaking

## Current Phase

Implementation Preparation

## Current Unity Implementation Phase

Phase 0 - Project Setup

## Current Task

Define the Unity project structure for rakugaking.

## Project Concept

rakugaking is a chaotic battle game where players draw/program characters and make them fight.

The intended fun comes from imperfect movement, awkward behavior, and unexpected results.

## Confirmed Direction

- ADeL is used as the project flow and management method
- ADeL for Unity is used as a Unity-specific reference/manual
- rakugaking is the actual production repository
- Development state should be managed inside this repository
- The owner does not need to read code
- AI should manage implementation tasks and state updates

## Current Repository Role

This repository is the real development site for rakugaking.

ADeL management files should live here so that another AI can resume work without needing the full chat history.

## Important Decisions

- Do not force the owner to act as a message relay between ADeL and Unity
- Keep project management and Unity work state together in this repository
- Work in small Unity tasks
- Do not add new specs repeatedly during implementation
- Update PROJECT_STATE.md, HANDOFF.md, and NEXT_TASK.md as the work progresses

## Known Issues / Unknowns

- Unity version is not decided
- Unity project folder name is not decided
- Unity template is not decided
- Target platform is not confirmed in this repository state
- First playable scene does not exist yet

## Do Not Change Without Approval

- Do not abandon the core game concept
- Do not skip to full game implementation before creating the minimum Unity foundation
- Do not add many new documents instead of progressing the Unity setup
- Do not require the owner to read code as the main confirmation method

## Next Task

See NEXT_TASK.md.

## How To Resume

1. Read PROJECT_STATE.md
2. Read HANDOFF.md
3. Read NEXT_TASK.md
4. Complete only the next task
5. Update these files after meaningful progress
6. Ask the owner to confirm only beginner-checkable Unity behavior
