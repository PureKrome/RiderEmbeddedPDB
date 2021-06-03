<h1 align="center">Jetbrains Rider: Embedded PDB experiment</h1>

<br />

<div align="center">
    <!-- License -->
    <a href="https://choosealicense.com/licenses/mit/">
    <img src="https://img.shields.io/badge/License-MIT-blue.svg?style=flat-square" alt="License - MIT" />
    </a>
</div>

### Summary

This is an experiment to see if Jetbrain's Rider can handle nuget packages where the PDB's have been embedded.

Can we step into / debug a 3rd party PDB if it's available via Nuget?

### Details

There's two solutions:
- `RiderEmbeddedPDB.sln` : this is the test class library which I manually created the `nupkg` and manually published to MyGet (so I don't pollute the main NuGet.org feed)
- `RiderEmbeddedPDB-TestApplication.sln` : this is a console app which has a reference to the `nupkg` on MyGet.

When I debug/step into a method in my test application, this prooves that the debug information is via the embedded PDB.

![image](https://user-images.githubusercontent.com/899878/120660354-952b1a80-c4ca-11eb-8e69-8e87539ba0fa.png)


---
