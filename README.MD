[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]



<!-- PROJECT LOGO -->
<br />

<p align="center">
  <p>
    <img src="https://scontent.fdad3-3.fna.fbcdn.net/v/t1.6435-9/195330762_815493585758575_987548520873735606_n.jpg?_nc_cat=100&ccb=1-3&_nc_sid=0debeb&_nc_ohc=ij4vYxZDONEAX_9m1go&_nc_ht=scontent.fdad3-3.fna&oh=c2dcfb4a69219e93d8bdd3118848ade1&oe=60E63461" alt="Logo">
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

![Screen Shot](https://scontent-hkg4-1.xx.fbcdn.net/v/t1.6435-9/196262815_815493562425244_2787253262331034431_n.jpg?_nc_cat=107&ccb=1-3&_nc_sid=0debeb&_nc_ohc=VArMYZfRGFAAX_TeB0R&_nc_ht=scontent-hkg4-1.xx&oh=d259b910f622cd75a6adcbe0a3a36143&oe=60E35618)

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
3. Open solution file with Visual Studio and follow these steps : 
   ```
   Tools -> NuGet Package Manager -> Package Manager Console
   ```
4. Type this command then Enter to migrate the database
   ```sh
    update-database
   ```
5. Build and use the application with default Account : 
	```sh
    Username : admin
	Password : 1
   ```


<!-- USAGE EXAMPLES -->
## Usage

**1. Login**
    <br/>
    <br/>
    ![image_login](https://scontent-hkg4-1.xx.fbcdn.net/v/t1.6435-9/195136548_815493202425280_9115940674959402738_n.jpg?_nc_cat=102&ccb=1-3&_nc_sid=0debeb&_nc_ohc=dQ5kEyAjKDoAX8S1VTi&_nc_ht=scontent-hkg4-1.xx&oh=c304edd4a4d3815eb1e2b581c37c60ad&oe=60E5E1AD)
    
**2. Home Screen**
    <br/>
    <br/>
    ![image_home](https://scontent-hkg4-2.xx.fbcdn.net/v/t1.6435-9/198725438_815493265758607_4613143609379069645_n.jpg?_nc_cat=111&ccb=1-3&_nc_sid=0debeb&_nc_ohc=6y8WpBFW-MEAX_XgpgM&_nc_ht=scontent-hkg4-2.xx&oh=bbc715c4a24ec6da12005dd1245df0a2&oe=60E63E36)

**3. Stadium and Service Form**
    <br/>
    <br/>
    ![image_stadium](https://scontent-hkg4-1.xx.fbcdn.net/v/t1.6435-9/196232838_815493219091945_2900183378599531491_n.jpg?_nc_cat=102&ccb=1-3&_nc_sid=0debeb&_nc_ohc=s2t0S2vIk80AX-_jsBv&_nc_ht=scontent-hkg4-1.xx&oh=52fcae6afb304d29f3a53aa791cbb76a&oe=60E60FF6)
    <br/>
    <br/>
    ![image_service](https://scontent-hkg4-2.xx.fbcdn.net/v/t1.6435-9/194776954_815493292425271_1371536743179565002_n.jpg?_nc_cat=104&ccb=1-3&_nc_sid=0debeb&_nc_ohc=k4HRD4xs7JEAX95L8y3&_nc_oc=AQnS_zLvR8DLB9ezb6e7v17UUL68mymN1SAwyztvGjUihw3p9b6lfEYkpAJinWbrIbXltIRW8QUpU_fbfWyzCI2z&tn=LmsjCjdx2PD-F9Wv&_nc_ht=scontent-hkg4-2.xx&oh=bddd1e1319a5fbf7897ecc6f230d4a11&oe=60E2D89C)

**4. Cashier and Account Form**
    <br/>
    <br/>
    ![image_cashier](https://scontent-hkg4-2.xx.fbcdn.net/v/t1.6435-9/195043524_815493319091935_4438745078750132156_n.jpg?_nc_cat=110&ccb=1-3&_nc_sid=0debeb&_nc_ohc=cHshBRfS2ccAX9oXvAN&_nc_ht=scontent-hkg4-2.xx&oh=fd9314e37c3e2d201b0abea87fbcc8ff&oe=60E4CDA1)
    <br/>
    <br/>
    ![image_account](https://scontent-hkg4-2.xx.fbcdn.net/v/t1.6435-9/195314758_815493305758603_7974174112657686129_n.jpg?_nc_cat=110&ccb=1-3&_nc_sid=0debeb&_nc_ohc=8JukYCZjFgwAX9b4cg7&_nc_ht=scontent-hkg4-2.xx&oh=140e2562b3c94845866d5ee191afead8&oe=60E55CE8)
    
**5. Customer Form**
    <br/>
    <br/>
    ![image_customer](https://scontent.fdad3-3.fna.fbcdn.net/v/t1.6435-9/194380627_815493429091924_5481814397208925177_n.jpg?_nc_cat=100&ccb=1-3&_nc_sid=0debeb&_nc_ohc=BTcN7kcHTN4AX-YuFn8&_nc_ht=scontent.fdad3-3.fna&oh=ae648a61acd91693dafd27aaf5acb671&oe=60E3C7D0)
    
**6. Bill Form**
    <br/>
    <br/>
    ![image_bill](https://scontent-hkg4-1.xx.fbcdn.net/v/t1.6435-9/194548540_815493349091932_1322435278562048721_n.jpg?_nc_cat=107&ccb=1-3&_nc_sid=0debeb&_nc_ohc=aXF8EHxmTckAX_gtRrK&_nc_ht=scontent-hkg4-1.xx&oh=d099627873a574a3fd08cd5aebbb57d6&oe=60E67DA6)

**7. Stadium and Service Order Form**
    <br/>
    <br/>
    ![image_stadiumorder](https://scontent-hkg4-1.xx.fbcdn.net/v/t1.6435-9/194897947_815493372425263_9040807109111928773_n.jpg?_nc_cat=103&ccb=1-3&_nc_sid=0debeb&_nc_ohc=7Jt99x8dpUIAX8X8N95&_nc_ht=scontent-hkg4-1.xx&oh=efbe4d370d450ca2c4acf78fdccfb2f2&oe=60E6763D)
    <br/>
    <br/>
    ![image_serviceorder](https://scontent-hkg4-2.xx.fbcdn.net/v/t1.6435-9/197544575_815493375758596_3286887774662187651_n.jpg?_nc_cat=111&ccb=1-3&_nc_sid=0debeb&_nc_ohc=vYjfJ5PW2QcAX-cbu1-&tn=LmsjCjdx2PD-F9Wv&_nc_ht=scontent-hkg4-2.xx&oh=756cce859ac1e71830e3da635df0ea0e&oe=60E2F216)
    
**8. Bill Printing**
    <br/>
    <br/>
    ![image_print](https://scontent-hkg4-1.xx.fbcdn.net/v/t1.6435-9/196525769_815493209091946_3014370135695533723_n.jpg?_nc_cat=106&ccb=1-3&_nc_sid=0debeb&_nc_ohc=_TrHkSuovAUAX-0TDBy&_nc_ht=scontent-hkg4-1.xx&oh=32d5f5b023e0959233726cf131d87a15&oe=60E65CC0)

**9. Statistic Form (Predict by Linear Regression)**
    <br/>
    <br/>
    ![image_history](https://scontent-hkg4-2.xx.fbcdn.net/v/t1.6435-9/194344631_815493259091941_5577392730271391455_n.jpg?_nc_cat=111&ccb=1-3&_nc_sid=0debeb&_nc_ohc=cokoFwifEBMAX9C0t8j&_nc_ht=scontent-hkg4-2.xx&oh=11fc5fb0d6661cf324da9c2214b088ed&oe=60E5BFE3)
    <br/>
    <br/>
    ![image_statistic](https://scontent-hkg4-1.xx.fbcdn.net/v/t1.6435-9/195772363_815493435758590_4634449477676191199_n.jpg?_nc_cat=108&ccb=1-3&_nc_sid=0debeb&_nc_ohc=BpYPCfe3CPcAX-YO1tj&_nc_ht=scontent-hkg4-1.xx&oh=194c8eee46071061f01bc33b64aade4a&oe=60E5E934)
	  <br/>
    <br/>
    ![image_predict](https://scontent-hkg4-2.xx.fbcdn.net/v/t1.6435-9/194317507_815493462425254_5554214804572269630_n.jpg?_nc_cat=109&ccb=1-3&_nc_sid=0debeb&_nc_ohc=ZEGlxnIBR5sAX83x4Va&_nc_ht=scontent-hkg4-2.xx&oh=46593656de2be6854c9b5fe8f53effcf&oe=60E5DA9F)	

**10. Bill Detail Form**
    <br/>
    <br/>
    ![image_detail](https://scontent.fdad3-3.fna.fbcdn.net/v/t1.6435-9/195853289_815493512425249_6268977186115640058_n.jpg?_nc_cat=100&ccb=1-3&_nc_sid=0debeb&_nc_ohc=u00GBZ8Mkv4AX_fKNIK&_nc_ht=scontent.fdad3-3.fna&oh=6705f8f6ed9d9b9ed6fc7ef697599250&oe=60E3004E)

**11. Setting Form**
    <br/>
    <br/>
    ![image_setting](https://scontent-hkg4-1.xx.fbcdn.net/v/t1.6435-9/196859947_815493505758583_3519415714814294601_n.jpg?_nc_cat=108&ccb=1-3&_nc_sid=0debeb&_nc_ohc=0moSKJjTssgAX9PcVL-&tn=LmsjCjdx2PD-F9Wv&_nc_ht=scontent-hkg4-1.xx&oh=a56c3c3883e97a22dfd714027a4ee17a&oe=60E51D3D)

**12. Beautiful Alert with each Validation Result**
    <br/>
    <br/>
    ![image_alert](https://scontent-hkg4-1.xx.fbcdn.net/v/t1.6435-9/197515128_815493529091914_8345773639131057577_n.jpg?_nc_cat=106&ccb=1-3&_nc_sid=0debeb&_nc_ohc=fXNQ3q0SK6QAX8ZGT6a&_nc_ht=scontent-hkg4-1.xx&oh=2b02e763b11f48b3434f538e44a10a5d&oe=60E5B35D)

**13. Sorting data by clicking the column header (SortableBindingList<T>)**
    <br/>
    <br/>
    ![image_sort](https://scontent.fdad3-3.fna.fbcdn.net/v/t1.6435-9/198513473_817104982264102_7771651234584924067_n.jpg?_nc_cat=100&ccb=1-3&_nc_sid=0debeb&_nc_ohc=qp861-ZAZ6oAX98c_Eh&_nc_ht=scontent.fdad3-3.fna&oh=c3ad9e6b3e223c7cb8eea91e25451f40&oe=60C88AB3)
 

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
