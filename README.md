# BugLite – Minimal Local Bug Tracker

## Overview

**BugLite** is a lightweight, portable bug tracker designed for small projects and personal use.
It focuses on simplicity: record issues, track their status, and organize them by project — no database server required.

* **Platform:** Windows (WinForms)
* **Storage:** JSON file (`bugs.json`)
* **UI:** Clean list-based interface with project/status filters
* **Goal:** Minimal setup, fast and portable, easy to extend

---

## Features

* Track issues with:

  * ID (auto-increment)
  * Project
  * Title / short description
  * Status: Open / In Progress / Closed
  * Detailed description
  * Creation and closing dates
* Filter and sort by Project and Status
* Add, edit, delete issues via dialogs
* All data stored in a single JSON file — portable and human-readable
* Optional future enhancements: export to CSV, search box, tags/labels, priorities

---

## Screenshots / UI Mockups (Ideas)

> *(Placeholder images, to be replaced when there will be a working prototype)*

* Main window with **ListView showing all issues**
* “New Bug” dialog with input fields for Project, Title, Status, Description
* Optional filter panel: Project dropdown + Status dropdown

---

## Installation

1. Download the executable (`BugLite.exe`) and place it in any folder.
2. Run `BugLite.exe` → creates `bugs.json` automatically if missing.
3. Start adding issues right away — no setup required.

---

## Usage

* **Add Bug:** Click “New” → fill in fields → OK
* **Edit Bug:** Select a bug → click “Edit” → modify → OK
* **Delete Bug:** Select a bug → click “Delete”
* **Filter:** Select Project / Status from dropdowns to narrow the list

---

## Roadmap / Future Enhancements

* Multi-project support with separate JSON files per project
* Search/filter by text, date, or priority
* Export to CSV / JSON for reporting
* Optional “user roles” for team collaboration
* Optional attachments per bug
* Optional dark/light theme

> *Composed in a dialog with ChatGPT*
