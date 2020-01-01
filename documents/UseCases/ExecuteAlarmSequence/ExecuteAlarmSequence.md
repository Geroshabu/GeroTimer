# Execute alarm sequence

## 💬 Use Case Description

### Summary

Execute the alarm sequence that is created by user.

### Actors

* User

### Primary Flow

1. User clicks "Play" button of the main window.
2. The system executes each items of the alarm sequence. The flow for a item depend on its item type.
  * If the item type is "Wait"
    1. The system does nothing for the time set on the item.
  * If the item type is "Alarm"
    1. The system rings alarm for the time set on the item.

### Alternative Flows

#### 3-A : If user clicks the "Pause" button

1. The system pauses execution of the current item.
2. User clicks the "Play" button again.
3. The system resumes the current item execution.
4. Back to step 3 of the primary sequence.

#### 3-A-2-A : If user clicked the "Stop" button

1. Abort this use case.

#### 3-B : If user clicks the "Stop" button

1. Abort this use case.

### Pre-condition

* The main window is displaying

### Post-condition

* The main window is displaying
