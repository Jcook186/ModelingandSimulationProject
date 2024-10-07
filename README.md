# ModelingandSimulationProject
Goals
  - The main Goals of the Model Implementation using Unity is to provide a visual representation of the DoS attack as it occurs, while also showcasing protection methods and their relative effectiveness againts DoS attacks.
    
Plans
  - Although the project is not close to completion, I've provided a simple overview using Unity's 2D UI to help envision the direction of the project.
  - In it We see two users, one standard and one malicious. Both users are sending Data packets to the network client.
  - Once the code is up and running, I plan on having the simulation automatically begin sending datapackets to the network. At any time the user can press a button to simulate an attack, which will activate a method to create a botNetwork to flood the network with resource requests, potentially crashing it.
  - However I also plan to showcase protection methods, such as filtration.
  - For Filtration, Ill provide the network client with a list of acceptable IP Prefixes. Anything outside these prefixes will immediately be rejected.
  - After Inital layers of protection, I also Plan to include an identification algorithm, or atleast a representation of one. This will allow the network to potentially identify any further malicious packets who made it through the initial protection.
  - This is to also showcase the importance of Layers of Security. When it comes to DoS attacks, and Cyber Security in general. its best to have as many layers of protection as possible, because there is always a weakness/oversight.
  - I plan to Record Data surrounding things such as: Network Stability, # of network Crashes/failures, Efficiency % of Protection, etc... I want to record an average, but also present this information live to the user to provide another visual aid for the simulation.

Document Changes
  - I have not received any feedback on my UML or my Literature review, so there has not been any changes to them since their submission.
