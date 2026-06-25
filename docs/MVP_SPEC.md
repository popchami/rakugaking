# MVP Specification

## Metadata

| Item | Value |
|---|---|
| Project Name | rakugaking |
| Document Type | MVP Specification |
| Status | Draft |
| Version | 0.1.0 |
| Created | 2026-06-25 |
| Updated | 2026-06-25 |
| Owner | popchami |

---

## 1. MVP Purpose

rakugaking の最初のMVP範囲を定義すること。

現時点ではプロジェクト内容が未確定のため、このMVP_SPECは「実装開始前の整理用ドラフト」として扱います。

---

## 2. MVP Goals

- プロジェクト種別を決める
- MVPで作る画面・機能・データを決める
- 実装開始前にAIが参照する仕様書を整える

---

## 3. MVP Principles

- 最小機能で完成させる
- 将来機能を先に作らない
- 便利機能より主要体験を優先する
- 複雑にしすぎない
- 後で壊れやすい構成にはしない

---

## 4. Target Platforms

| Platform | MVP Target | Notes |
|---|---|---|
| iOS | TBD | 未定 |
| Android | TBD | 未定 |
| Web | TBD | 未定 |
| Desktop | No | 現時点では対象外 |
| Other | No | 現時点では対象外 |

---

## 5. MVP Screens

| Screen ID | Screen Name | Purpose | MVP |
|---|---|---|---|
| SCREEN-001 | TBD | 未定 | TBD |

---

## 6. MVP Features

| Feature ID | Feature Name | Purpose | Priority | Related Screen |
|---|---|---|---|---|
| FEATURE-001 | TBD | 未定 | High | SCREEN-001 |

---

## 7. Required Data

| Data ID | Entity | Purpose | Required |
|---|---|---|---|
| DATA-001 | TBD | 未定 | TBD |

詳細は `DATA_SPEC.md` に書きます。

---

## 8. Not Included in MVP

| Item | Reason | Future Candidate |
|---|---|---|
| 未定機能 | 仕様未確定のため | Yes |
| 過剰な演出 | MVP優先のため | Yes |
| 複雑な外部連携 | 初期開発を重くしないため | Yes |

---

## 9. MVP User Flow

```txt
TBD
↓
TBD
↓
TBD
```

---

## 10. Acceptance Criteria

- [ ] MVP対象画面がすべて定義されている
- [ ] MVP対象機能がすべて定義されている
- [ ] 必要なデータが定義されている
- [ ] 主要ユーザーフローが定義されている
- [ ] MVP外の機能が分離されている
- [ ] 手動確認手順がある
- [ ] 引き継ぎ情報が `HANDOFF.md` に残っている

---

## 11. Manual Test Checklist

| No | Test | Expected Result |
|---|---|---|
| 1 | TBD | TBD |

---

## 12. Related Documents

| Document | Role |
|---|---|
| PROJECT_OVERVIEW.md | プロジェクト全体方針 |
| FEATURE_SPEC.md | 機能詳細 |
| UI_UX_SPEC.md | 画面仕様 |
| DATA_SPEC.md | データ仕様 |
| TEST_PLAN.md | テスト方針 |
| HANDOFF.md | 作業状況の引き継ぎ |

---

## 13. AI Instructions

AIはMVP開発時、以下を守ること。

- MVP Features にない機能を勝手に実装しない
- Not Included in MVP にあるものを実装しない
- MVP Screens にない画面を勝手に追加しない
- Required Data にないデータ項目を勝手に追加しない
- 思いついた改善は実装せず、将来候補として記録する
