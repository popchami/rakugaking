# Architecture

## Metadata

| Item | Value |
|---|---|
| Project Name | rakugaking |
| Status | Draft |
| Version | 0.1.0 |
| Created | 2026-06-25 |
| Updated | 2026-06-25 |

---

## 1. Purpose

このドキュメントの目的は、技術構成を固定し、AIが場当たり的な実装をしないようにすることです。

現時点では技術構成は未定です。

---

## 2. Technology Stack

| Area | Technology | Reason |
|---|---|---|
| Frontend | TBD | 未定 |
| Backend | TBD | 未定 |
| Database | TBD | 未定 |
| State Management | TBD | 未定 |
| Testing | TBD | 未定 |
| Deployment | TBD | 未定 |

---

## 3. Architecture Overview

```txt
<User>
↓
<UI Layer>
↓
<Application / State Layer>
↓
<Repository / Service Layer>
↓
<Data Source>
```

---

## 4. Directory Structure

```txt
rakugaking/
├─ README.md
└─ docs/
   ├─ 00_START_HERE.md
   ├─ PROJECT_OVERVIEW.md
   ├─ MVP_SPEC.md
   ├─ ARCHITECTURE.md
   ├─ DATA_SPEC.md
   ├─ UI_UX_SPEC.md
   ├─ FEATURE_SPEC.md
   ├─ AI_RULES.md
   ├─ TEST_PLAN.md
   └─ HANDOFF.md
```

実装ディレクトリは、技術構成決定後に追加します。

---

## 5. Layer Responsibilities

| Layer | Responsibility | Must Not Do |
|---|---|---|
| UI | 表示とユーザー操作 | データ保存を直接行わない |
| State | 状態管理 | UI依存の処理を持たない |
| Repository | データ操作 | UIを知らない |
| Data Source | 保存・通信 | ビジネス判断をしない |

---

## 6. Dependency Rules

- 上位レイヤーは下位レイヤーに依存してよい
- 下位レイヤーは上位レイヤーに依存しない
- UIからデータソースを直接呼ばない
- 共通処理は重複させず、適切な場所に分離する

---

## 7. Package / Library Rules

- 新しいライブラリを勝手に追加しない
- 標準機能で実現できる場合は標準機能を優先する
- 追加が必要な場合は理由を記録する

---

## 8. Naming Rules

| Target | Rule | Example |
|---|---|---|
| File | TBD | TBD |
| Class | TBD | TBD |
| Function | TBD | TBD |
| Variable | TBD | TBD |

---

## 9. Error Handling Policy

- ユーザーに分かるエラー表示を行う
- 失敗してもアプリ全体を停止させない
- ログが必要な場合は責務を分ける
- エラー内容を握りつぶさない

---

## 10. Performance Policy

- MVPでは過剰最適化しない
- 明らかな非効率は避ける
- 大量データを扱う可能性がある箇所は拡張余地を残す

---

## 11. Security Policy

- 秘密情報をコードに直接書かない
- 個人情報を不要に保存しない
- 外部通信がある場合は認証・権限を考慮する
