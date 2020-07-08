# Peter Moss COVID-19 AI Research Project
## Magic Leap 1 COVID-19 Detection System

[![Magic Leap 1 COVID-19 Detection System](Media/Images/magic-leap-1-covid-19-detection-system.png)](https://github.com/COVID-19-AI-Research-Project/Magic-Leap-1-Detection-System)

[![CURRENT VERSION](https://img.shields.io/badge/CURRENT%20VERSION-0.1.0-blue.svg)](https://github.com/COVID-19-AI-Research-Project/Magic-Leap-1-Detection-System/tree/0.1.0) [![CURRENT DEV BRANCH](https://img.shields.io/badge/CURRENT%20DEV%20BRANCH-0.2.0-blue.svg)](https://github.com/COVID-19-AI-Research-Project/AI-Classification/tree/0.2.0)

&nbsp;

# Table Of Contents

- [Introduction](#introduction)
- [DISCLAIMER](#disclaimer)
- [About Magic Leap 1](#about-magic-leap-1)
- [About Unity 3D](#about-unity-3d)
- [Projects](#projects)
- [Contributing](#contributing)
  - [Contributors](#contributors)
- [Versioning](#versioning)
- [License](#license)
- [Bugs/Issues](#bugs-issues)

&nbsp;

# Introduction

The Magic Leap 1 COVID-19 Detection System 2020 uses Tensorflow 2, Raspberry Pi 4 & Magic Leap 1 to provide a spatial computing detection system.

The project uses the [COVID-19 Tensorflow DenseNet Classifier](https://github.com/COVID-19-AI-Research-Project/AI-Classification/blob/master/Projects/2 "COVID-19 Tensorflow DenseNet Classifier") a Tensorflow implementation of DenseNet and the [SARS-COV-2 Ct-Scan Dataset](https://www.kaggle.com/plameneduardo/sarscov2-ctscan-dataset "SARS-COV-2 Ct-Scan Dataset"), a large dataset of CT scans for SARS-CoV-2 (COVID-19) identification created by our partners at [Lancaster University](https://www.lancaster.ac.uk/), Plamenlancaster: [Professor Plamen Angelov](https://www.lancaster.ac.uk/lira/people/#d.en.397371) Centre Director @ [Lira](https://www.lancaster.ac.uk/lira/), & his researcher, [Eduardo Soares PhD](https://www.lancaster.ac.uk/sci-tech/about-us/people/eduardo-almeida-soares).

We use the trained model from **COVID-19 Tensorflow DenseNet Classifier** with the [COVID-19 Tensorflow DenseNet Classifier For Raspberry Pi 4](https://github.com/COVID-19-AI-Research-Project/AI-Classification/blob/master/Projects/3 "COVID-19 Tensorflow DenseNet Classifier For Raspberry Pi 4") and serve an API endpoint that exposes the Artificial Intelligence classifier allowing **Magic Leap 1** to communicate with it.

&nbsp;

# DISCLAIMER

These projects should be used for research purposes only. The purpose of the projects are to show the potential of Spatial Computing, Artificial Intelligence, and the Internet of Things for medical support systems such as diagnosis systems. 

Although the classifier used in this project is very accurate and shows good results both on paper and in real world testing, it is not meant to be an alternative to professional medical diagnosis. 

Developers that have contributed to this repository have experience in using Artificial Intelligence for detecting certain types of cancer & COVID-19. They are not a doctors, medical or cancer/COVID-19 experts. Please use these systems responsibly.

&nbsp;

# About Magic Leap 1

[![Magic Leap 1](Media/Images/magic-leap-1.jpg)](https://www.magicleap.com/en-us/magic-leap-1)

This project uses the revolutionary Magic Leap 1 and Magic Leap's Spatial Computing Environment. Magic Leap 1 is a lightweight headset that uses Spatial Computing to map out rooms allowing applications to understand their enviroment and to interact accordingly. 

To develop applications for Magic Leap 1 we use the [Magic Leap Lab](https://developer.magicleap.com/downloads "Magic Leap Lab") which allows us to use [Lumin SDK](https://developer.magicleap.com/en-us/learn/guides/lumin-sdk-latest-release-notes "Lumin SDK"), Lumin Runtime editor, and SDK packages for [Unity Software](https://unity.com/ "Unity Software") and [Unreal Editor](https://www.unrealengine.com/en-US/ "Unreal Editor").

**We would like to thank Magic Leap for sponsoring our association with the Magic Leap 1. This is just one of the many medical applications we will be building with Magic Leap to assist in the fight against COVID-19 and Leukemia.**

We would also like to thank Rodney at MagicalLightandSound for personally taking his time to help us get off the ground with using the Unity development platform with Magic Leap. You can follow his tutorials on his [Github](https://github.com/magicallightandsound "Github") and [Twitch](https://www.twitch.tv/rodneydeveloper "Twitch"). 

&nbsp;

# About Unity 3D

[![Unity](Media/Images/unity.jpg)](https://unity.com/)

This project uses [Unity 3d](https://unity.com/ "Unity 3d"), a real-time 3D development platform. Combined with the [Lumin SDK](https://developer.magicleap.com/en-us/learn/guides/lumin-sdk-latest-release-notes "Lumin SDK"), Unity allows you to create breath taking, next generation projects for the Magic Leap Spatial Computing Environment. 

&nbsp;

# Projects

Below you will find details of the projects in this repository. Projects with HIAS = YES are compatible with [HIAS](https://github.com/LeukemiaAiResearch/HIAS "HIAS").

| ID  | Platform                                                                                                    | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 | HIAS | Author                                                                                                        |
| --- | ---------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---- | ------------------------------------------------------------------------------------------------------------- |
| 1   | [Unity](Projects/Unity/ "Unity") | The Magic Leap 1 COVID-19 Detection System built using the Unity 3D Development Platform.                                                                                                                                                                                                                                                                                                   | YES   |  [Adam Milton-Barker](https://www.leukemiaresearchassociation.ai/team/adam-milton-barker "Adam Milton-Barker") |

&nbsp;

# Contributing

The Peter Moss COVID-19 AI Research Project encourages and welcomes code contributions, bug fixes and enhancements from the Github.

Please read the [CONTRIBUTING](CONTRIBUTING.md "CONTRIBUTING") document for a full guide to forking our repositories and submitting your pull requests. You will also find information about our code of conduct on this page.

## Contributors

- [Adam Milton-Barker](https://www.leukemiaresearchassociation.ai/team/adam-milton-barker "Adam Milton-Barker") - [Asociacion De Investigation En Inteligencia Artificial Para La Leucemia Peter Moss](https://www.leukemiaresearchassociation.ai "Asociacion De Investigation En Inteligencia Artificial Para La Leucemia Peter Moss") President & Lead Developer, Sabadell, Spain

- [Lancaster University (PlamenLancaster)](https://www.leukemiaresearchassociation.ai/team/adam-milton-barker "Lancaster University (PlamenLancaster)") - [Professor Plamen Angelov](https://www.lancaster.ac.uk/lira/people/#d.en.397371) & [Eduardo Soares PhD](https://www.lancaster.ac.uk/sci-tech/about-us/people/eduardo-almeida-soares)

&nbsp;

# Versioning

We use SemVer for versioning. For the versions available, see [Releases](releases "Releases").

&nbsp;

# License

This project is licensed under the **MIT License** - see the [LICENSE](LICENSE "LICENSE") file for details.

&nbsp;

# Bugs/Issues

We use the [repo issues](issues "repo issues") to track bugs and general requests related to using this project. See [CONTRIBUTING](CONTRIBUTING.md "CONTRIBUTING") for more info on how to submit bugs, feature requests and proposals.