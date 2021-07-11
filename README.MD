[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]



<!-- PROJECT LOGO -->
<br />

<p align="center">
  <p>
    <img src="/screen-shot/0.jpg" width=100% alt="Logo">
  </p>

  <h3 align="center">STADIUM MANAGEMENT</h3>

  <p align="center">
    <br />
    <a href="#">View Demo</a>
    ·
    <a href="#">Report Bug</a>
    ·
    <a href="#">Request Feature</a>
  </p>
</p>

<!-- TABLE OF CONTENTS -->
<details open="open">
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#roadmap">Roadmap</a></li>
    <li><a href="#contributing">Contributing</a></li>
    <li><a href="#license">License</a></li>
    <li><a href="#contact">Contact</a></li>
    <li><a href="#acknowledgements">Acknowledgements</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## About The Project

![Screen Shot](/screen-shot/1.jpg)

Stadium Management is an application built by Windows Form Technology.
It will help stadium owner and their cashier easy to manage the business. 

Benefits:
* Beautiful UI.
* Easy to use.
* Digital conversion.
* Respond to the industrial revolution 4.0.

### Built With

This app is being developed by a group of student, currently studying at Danang University of Technology. We're using these technologies to develope the app:
* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
* [Windows Form](https://docs.microsoft.com/en-us/dotnet/desktop/winforms/?view=netframeworkdesktop-4.8)
* [Entity Framework 6](https://docs.microsoft.com/en-us/ef/ef6/)
* [Font Awesome Sharp](https://github.com/awesome-inc/FontAwesome.Sharp)
* [MaterialSkin](https://github.com/IgnaceMaes/MaterialSkin)
* [AutoMapper](https://github.com/AutoMapper/AutoMapper.EF6)


<!-- GETTING STARTED -->
## Getting Started

Necessary program to build and run this code:
  1. Visual Studio
  2. Microsoft SQL Server 2019
  

### Prerequisites

You still need to install these things first:
* .NET Framework 4.7.2


### Installation

1. Copy the address of the project
2. Clone the repo
   ```sh
   git clone https://github.com/phuocleoceo/StadiumManagement
   ```
3. Open with Visual Studio, change connectionstring in App.config (for both 3 project)
   ```
    "YourConnection": "Server={yourServerName};Database={yourDBName};Trusted_Connection=True;MultipleActiveResultSets=true"
   ```
4. Open StadiumContext.cs in DataAccessLayer and use Your Connection
   ```
    public StadiumContext() : base("name=YourConnection") { }
   ```
5. Follow these steps to open Package Manage Console : 
   ```
   Tools -> NuGet Package Manager -> Package Manager Console
   ```
6. Type this command then Enter to migrate the database
   ```sh
    update-database
   ```
7. Build and use the application with default Account : 
   ```sh
    Username : admin
    Password : 1
   ```


<!-- USAGE EXAMPLES -->
## Usage

**1. Login**
    <br/>
    <br/>
    ![image_login](/screen-shot/2.jpg)
    
**2. Home Screen**
    <br/>
    <br/>
    ![image_home](/screen-shot/3.jpg)

**3. Stadium and Service Form**
    <br/>
    <br/>
    ![image_stadium](/screen-shot/4.jpg)
    <br/>
    <br/>
    ![image_service](/screen-shot/5.jpg)

**4. Cashier and Account Form**
    <br/>
    <br/>
    ![image_cashier](/screen-shot/6.jpg)
    <br/>
    <br/>
    ![image_account](/screen-shot/7.jpg)
    
**5. Customer Form**
    <br/>
    <br/>
    ![image_customer](/screen-shot/8.jpg)
    
**6. Bill Form**
    <br/>
    <br/>
    ![image_bill](/screen-shot/9.jpg)

**7. Stadium and Service Order Form**
    <br/>
    <br/>
    ![image_stadiumorder](/screen-shot/10.jpg)
    <br/>
    <br/>
    ![image_serviceorder](/screen-shot/11.jpg)
    
**8. Bill Printing**
    <br/>
    <br/>
    ![image_print](/screen-shot/12.jpg)

**9. Statistic Form (Predict by Linear Regression)**
    <br/>
    <br/>
    ![image_history](/screen-shot/13.jpg)
    <br/>
    <br/>
    ![image_statistic](/screen-shot/15.jpg)
	<br/>
    <br/>
    ![image_predict](/screen-shot/16.jpg)	

**10. Bill Detail Form**
    <br/>
    <br/>
    ![image_detail](/screen-shot/14.jpg)

**11. Setting Form**
    <br/>
    <br/>
    ![image_setting](/screen-shot/17.jpg)

**12. Beautiful Alert with each Validation Result**
    <br/>
    <br/>
    ![image_alert](/screen-shot/18.jpg)

**13. Sorting data by clicking the column header (SortableBindingList<T>)**
    <br/>
    <br/>
    ![image_sort](/screen-shot/19.jpg)
 

<!-- ROADMAP -->
## Roadmap

See the [open issues](https://github.com/phuocleoceo/StadiumManagement) for a list of proposed features (and known issues).



<!-- CONTRIBUTING -->
## Contributing

Contributions are what make the open source community such an amazing place to be learn, inspire, and create. Any contributions you make are **greatly appreciated**.

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request



<!-- LICENSE -->
## License

Distributed under the MIT License. See `LICENSE` for more information.



<!-- CONTACT -->
## Contact

Facebook and Gmail : [Facebook](https://facebook.com/phuocleoceo) - ht10082001@gmail.com

Project Link : [Stadium Management](https://github.com/phuocleoceo/StadiumManagement)



<!-- ACKNOWLEDGEMENTS -->
## Acknowledgements
* [Modern UI for WF](https://www.youtube.com/watch?v=5AsJJl7Bhvc)
* [Modern UI for WF 2](https://www.youtube.com/watch?v=BtOEztT1Qzk)
* [Beautiful Alert](https://www.youtube.com/watch?v=QTWKUkiEqpQ)
* [Material Skin](https://www.youtube.com/watch?v=gEtXGyn8OMA)
* [Chart in WF](https://www.youtube.com/watch?v=gqo2TGpCOlA)
* [StackoverFlow](https://stackoverflow.com/)
* [Open Source License](https://choosealicense.com)
* [Font Awesome](https://fontawesome.com)





<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/badge/CONTRIBUTORS-_4_-brightgreen?style=for-the-badge
[contributors-url]: https://github.com/phuocleoceo/StadiumManagement/graphs/contributors
[forks-shield]: https://img.shields.io/badge/FORKS-_0_-blue?style=for-the-badge
[forks-url]: https://github.com/phuocleoceo/StadiumManagement/network/members
[stars-shield]: https://img.shields.io/badge/STARS-_0_-blue?style=for-the-badge
[stars-url]: https://github.com/phuocleoceo/StadiumManagement/stargazers
[issues-shield]: https://img.shields.io/github/issues/othneildrew/Best-README-Template.svg?style=for-the-badge
[issues-url]: https://github.com/phuocleoceo/StadiumManagement/issues
[license-shield]: https://img.shields.io/github/license/othneildrew/Best-README-Template.svg?style=for-the-badge
[license-url]: https://github.com/phuocleoceo/StadiumManagement/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[product-screenshot]: images/screenshot.png
