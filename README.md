<!-- PROJECT LOGO -->
<br />

![GitHub repo size](https://img.shields.io/github/repo-size/dylandasilva1999/spacify-app?color=%23f37723)
![GitHub watchers](https://img.shields.io/github/watchers/dylandasilva1999/spacify-app?color=%23f37723)
![GitHub language count](https://img.shields.io/github/languages/count/dylandasilva1999/spacify-app?color=%23f37723)
![GitHub code size in bytes](https://img.shields.io/github/languages/code-size/dylandasilva1999/spacify-app?color=%23f37723)

<h6 align="center">Dylan da Silva IDV 301</h6>
<p align="center">
</br>
   
  <a href="https://github.com/dylandasilva1999/yukihyo-virtualpet-app ">
    <img src="Images/AppIcon.png" alt="Logo" width="140" height="140">
  </a>
  
  <h3 align="center">Yukihyo</h3>

  <p align="center">
    Snow Leopard
      <br />
      <br />
      <a href="https://youtu.be/94Vm1dexcJo">View Demo</a>
       ·
       <a href="https://github.com/dylandasilva1999/yukihyo-virtualpet-app/issues">Report Bug</a>
       ·
       <a href="https://github.com/dylandasilva1999/yukihyo-virtualpet-app/issues">Request Feature</a>
   </p>

<!-- TABLE OF CONTENTS -->
## Table of Contents

* [About the Project](#about-the-project)
* * [Project Description](#project-description)
  * [Built with](#built-with)
* [Getting Started](#getting-started)
  * [Prerequisites](#prerequisites)
  * [How to install](#how-to-install)
* [Unit Testing](#unit-testing)
* [Features and Functionality](#features-and-functionality)
   * [Features](#features)
   * [Functionality](#functionality)
* [Concept Process](#concept-process)
   * [Ideation](#ideation)
   * [Wireframes](#wireframes)
   * [User-flow](#user-flow)
* [Development Process](#development-process)
   * [Implementation](#implementation)
   * [Future Development](#future-development)
* [Mockups](#mockups)
* [Video Demonstration](#video-demonstration)
* [Promo Video](#promo-video)
* [Roadmap](#roadmap)
* [Contributing](#contributing)
* [License](#license)
* [Contact](#contact)
* [Acknowledgements](#acknowledgements)

<!--PROJECT DESCRIPTION-->
## About the Project

![image1][image1]

### Project Description

According to an article posted by Team Wanderlust, the snow leopard was listed at number eight out of the 10 most endangered animals in the world. I chose the snow leopard to bring awareness to one of the most beautiful and unique animal species in the world.

The Snow Leopard according to an article on Treehugger stated that in 2017 the status changed from endangered to vulnerable, which caused the decrease in the population by major threats such as "Habitat Loss", “Poaching”, “Decline in Prey”, “Competition With Lifestock”, “Retaliatory Killing" and finally ”Climate Change”.

Yukihyo is a virtual pet application to inform users on the impact climate change and poachers have on endangered animals such as the snow leopard and encourage users to be aware of these dangers.

### Built With

* [Xamarin Forms]( https://docs.microsoft.com/en-us/xamarin/xamarin-forms/)
* [C# language](https://docs.microsoft.com/en-us/dotnet/csharp/)
* [Visual Studio](https://visualstudio.microsoft.com/)
* [GitHub](https://github.com/)

<img src="https://seeklogo.com/images/X/xamarin-logo-348B1EB629-seeklogo.com.png" width="5%" height="5%">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src="https://seeklogo.com/images/C/c-sharp-c-logo-02F17714BA-seeklogo.com.png" width="5%" height="5%">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src="https://static.wikia.nocookie.net/logopedia/images/6/62/Brand_Visual_Studio_Win_2019.svg/revision/latest/scale-to-width-down/340?cb=20191019024151" width="5%" height="5%">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<img src="https://upload.wikimedia.org/wikipedia/commons/9/91/Octicons-mark-github.svg" width="5%" height="5%">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

<!-- GETTING STARTED -->
## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

For development, the latest version of Visual Studio is required. The latest version can be downloaded from 

### How to install
 
1. Clone the repo
```sh
git clone https://github.com/dylandasilva1999/yukihyo-virtualpet-app.git
```
2. Open the project

Use `Open Workspace` in Visual Studio.

## Unit Testing

These are two examples of unit tests that can be run on this system. Navigate to Test Explorer to run the unit tests.

### GetLevelFromXpTest

The following test checks if the the correct level is assigned based on the Xp level. 
```
//ARRANGE
int xp = 1500;
int expectedLevel = 1;

//ACT
var result = Level.GetLevelFromXp(xp);

//ASSERT
Assert.AreEqual(expectedLevel, result);
```

### GetYukihyoStateTest

The following test checks if the correct state is selected based on the yukihyo string. 

```
//ARRANGE
string yukihyoString = "happy";
var expectedState = YukihyoState.happy;

//ACT
var result = YukihyoStates.GetYukihyoState(yukihyoString);

//ASSERT
Assert.AreEqual(expectedState, result);
```

<!-- FEATURES AND FUNCTIONALITY-->
## Features and Functionality

### Features

### Name and Rename your yukihyo

![image2][image2]

Choose any name for your yukihyo, and change it any time.

### Attend to your yukihyo's needs

![image3][image3]

Habitat, Hunger and Safety.

### Make your yukihyo cold

![image4][image4]

Add coldness by slidng the temperature to the right.

### Feed your yukihyo

![image5][image5]

Feed your yukihyo marmots by tapping on them.

### Keep your yukihyo safe

![image6][image6]

Catch the poachers by dragging and dropping them into jail.

### Learn to care for your yukihyo.

![image7][image7]

View the careguide and see why these interactions were chosen.

### Give your yukihyo attention.

![image8][image8]

Wake up your yukihyo and give belly rubs.

### Snow Leopard artwork created by me

The artwork was created with Adobe Illustrator.


### Functionality

* `Relative`, `Stack` and `Grid` layouts were used to create the layouts.
* `PushModalAsync` is used to navigation between various views.
* `Progress Bars` are utilised to indicate the states of the 3 different needs.
* `System.Timers` are implemented to decrease the needs.
* `Device` class is for storing data and information on the device.
* `Lottie Animations` is for displaying all animations on the app.
* `Pancakeview` for certain UI elements and layout. 

<!-- CONCEPT PROCESS -->
## Concept Process

The `Conceptual Process` is the set of actions, activities and research that was done when starting this project.

### Ideation

![image9][image9]

### Wireframes

![image10][image10]

### User-flow

![image11][image11]

<!-- DEVELOPMENT PROCESS -->
## Development Process

The `Development Process` is the technical implementations and functionality done in the backend of the application.

### Implementation

#### Challenges

* Understanding how C# integrates into Xamarin.Forms.
* Making the application responsive to various screen types was a great learning curve challenge.
* Using Xamarin.Forms to develop for cross-platform made way for interesting challenges.
* Learning how to make use of `Objects` and `Classes`.
* Grasping the concepts of `Public` and `Private` variables and functions.
* Ugghhh obvously working with `Emulators` as well.
* Letting interactions on different pages update the `Progress Bars`.

### Future Development

#### Future Changes

* Fix `Progress Bars` to update when interaction is complete.
* Improve on the `Performance` of the app, by updating the layout.
* Add more `Animations` in, such on the dashboard view.
* Refactor the game logic C# code of the app.

<!-- MOCKUPS -->
## Mockups

![image12][image12]

<!-- VIDEO DEMONSTRATION -->
## Video Demonstration

To see a run through of the application, click below:

[View Demo](https://youtu.be/94Vm1dexcJo)

<!-- PROMO VIDEO -->
## Promo Video

To see the promo video, click below:

[View Promo Video](https://www.youtube.com/watch?v=HJAQizqFTlI)

<!-- ROADMAP -->
## Roadmap

See the [open issues](https://github.com/dylandasilva1999/yukihyo-virtualpet-app/issues) for a list of proposed features (and known issues).

<!-- CONTRIBUTING -->
## Contributing

Contributions are what make the open source community such an amazing place to be learn, inspire, and create. Any contributions you make are **greatly appreciated**.

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

<!-- AUTHORS -->
## Authors

* **Dylan da Silva** - [DylandaSilva](https://github.com/dylandasilva1999)

<!-- LICENSE -->
## License

Distributed under the MIT License. See `LICENSE` for more information.\

<!-- LICENSE -->
## Contact

* **Dylan da Silva** - 190082@virtualwindow.co.za
* **Project Link** - https://github.com/dylandasilva1999/yukihyo-virtualpet-app

<!-- ACKNOWLEDGEMENTS -->
## Acknowledgements

* [Visual Studio Documenation](https://docs.microsoft.com/en-us/visualstudio/windows/?view=vs-2019)
* [Xamarin Forms Documenation](https://docs.microsoft.com/en-us/xamarin/xamarin-forms/)
* [How to render Lottie Animations](https://www.youtube.com/watch?v=inGKGQRuHok)
* [Creating a loading Screen](https://www.youtube.com/watch?v=y8ce7OyAgYU)
* [10 of the world's most endangered animals](https://www.wanderlust.co.uk/content/10-of-the-worlds-most-endangered-animals/)
* [Why the Snow Leopard Population Is Decreasing](https://www.treehugger.com/are-snow-leopards-endangered-5072563)
* [Different Layouts](https://www.youtube.com/watch?v=PVX0Wv_9kuA)
* [Flat Icon](https://www.flaticon.com/)

<!-- MARKDOWN LINKS & IMAGES -->
[image1]: Images/Image1.png
[image2]: Images/Image2.png
[image3]: Images/Image3.png
[image4]: Images/Image4.png
[image5]: Images/Image5.png
[image6]: Images/Image6.png
[image7]: Images/Image7.png
[image8]: Images/Image8.png
[image9]: Images/Image9.png
[image10]: Images/Image10.png
[image11]: Images/Image11.png
[image12]: Images/Image12.jpg

 
