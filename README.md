# UWPMemoryLeak
Contains memory leak issue reproducing sample in UWP project

**Title:** Memory Leak and Increased Process Memory in UWP App When Opening and Closing Popups with Custom ListBox View

**Description:**
Issue: The application's process memory exhibits a continuous increase, particularly noticeable when frequently opening and closing popups containing a custom ListBox view. This behavior suggests a potential memory leak within the UWP platform.

**Details:**

**Reproduction Steps:**
- Open the application.
- Perform actions to trigger the opening and closing of popups containing the custom ListBox view.
- Repeat the process multiple times.
**Expected Behavior:**
- The application's memory consumption should remain stable even with frequent popup interactions.
**Observed Behavior:**
- With each iteration of opening and closing popups, there's a noticeable increase in process memory usage.
The memory consumption keeps growing, indicating a potential memory leak.

**OutputVideo**


https://github.com/anandhan-rajagopal/UWPMemoryLeak/assets/97146406/c3ac843f-ebab-4613-8962-d23bb388cf38


