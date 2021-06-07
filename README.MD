[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]



<!-- PROJECT LOGO -->
<br />

<p align="center">
  <p>
    <img src="https://scontent.fdad3-3.fna.fbcdn.net/v/t1.6435-9/196789997_814940469147220_1420727862924083850_n.jpg?_nc_cat=100&ccb=1-3&_nc_sid=0debeb&_nc_ohc=adnvlULfYSoAX_viuqQ&tn=LmsjCjdx2PD-F9Wv&_nc_ht=scontent.fdad3-3.fna&oh=ff1859d69a94de444637d6c85740ac59&oe=60E50944" alt="Logo">
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

![Screen Shot](https://scontent-hkg4-1.xx.fbcdn.net/v/t1.6435-9/194261101_814940775813856_2376699939974873695_n.jpg?_nc_cat=107&ccb=1-3&_nc_sid=0debeb&_nc_ohc=XbzuDaczLcsAX-wmK_l&_nc_ht=scontent-hkg4-1.xx&oh=f76d285a8f0d54c83a215165a80da914&oe=60E2FB8C)

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
    ![image_login](https://scontent-hkg4-1.xx.fbcdn.net/v/t1.6435-9/195736060_814940409147226_2029524974074936563_n.jpg?_nc_cat=108&ccb=1-3&_nc_sid=0debeb&_nc_ohc=R1TbFeGjcXAAX_XEpua&_nc_ht=scontent-hkg4-1.xx&oh=aa88034d45dc65998df4a31d85e16c6d&oe=60E49834)
    
**2. Control Form**
    <br/>
    <br/>
    ![image_control](https://scontent.fdad3-3.fna.fbcdn.net/v/t1.6435-9/195874634_814940479147219_4303966792492402157_n.jpg?_nc_cat=101&ccb=1-3&_nc_sid=0debeb&_nc_ohc=AhlYGyRTunkAX9E1i-W&_nc_ht=scontent.fdad3-3.fna&oh=2ffde635824c6a3ee88c4ad448835e6a&oe=60E28DA0)

**3. Stadium and Service Form**
    <br/>
    <br/>
    ![image_stadium](https://scontent-hkg4-2.xx.fbcdn.net/v/t1.6435-9/196190871_814940425813891_3358727458727192304_n.jpg?_nc_cat=111&ccb=1-3&_nc_sid=0debeb&_nc_ohc=Oo9NcK5XhOsAX978u3y&_nc_ht=scontent-hkg4-2.xx&oh=59dd8c30ce23cc9779b9f4c9e1ef5817&oe=60E4852A)
    <br/>
    <br/>
    ![image_service](https://scontent-hkg4-1.xx.fbcdn.net/v/t1.6435-9/193709374_814940519147215_5517831371054033263_n.jpg?_nc_cat=105&ccb=1-3&_nc_sid=0debeb&_nc_ohc=1UEXtxJJti8AX-M5eiJ&_nc_ht=scontent-hkg4-1.xx&oh=aea4d72854b935bdcc21cdfd0cd72477&oe=60E1B6FD)

**4. Cashier and Account Form**
    <br/>
    <br/>
    ![image_cashier](https://scontent.fdad3-3.fna.fbcdn.net/v/t1.6435-9/195338529_814940529147214_1547154576654308247_n.jpg?_nc_cat=101&ccb=1-3&_nc_sid=0debeb&_nc_ohc=cHaruSw5CgIAX8FtQP-&_nc_ht=scontent.fdad3-3.fna&oh=b784a810b38bbe9a87609fd2baa42690&oe=60E46B20)
    <br/>
    <br/>
    ![image_account](https://scontent-hkg4-2.xx.fbcdn.net/v/t1.6435-9/196709792_814940545813879_7640919019193175107_n.jpg?_nc_cat=109&ccb=1-3&_nc_sid=0debeb&_nc_ohc=VmHE-0H8cj4AX-0mSBH&tn=LmsjCjdx2PD-F9Wv&_nc_ht=scontent-hkg4-2.xx&oh=8a5eeacc7eae30256ae2b9091afb397e&oe=60E446A9)
    
**5. Customer Form**
    <br/>
    <br/>
    ![image_customer](https://scontent-hkg4-2.xx.fbcdn.net/v/t1.6435-9/196709792_814940545813879_7640919019193175107_n.jpg?_nc_cat=109&ccb=1-3&_nc_sid=0debeb&_nc_ohc=VmHE-0H8cj4AX-0mSBH&tn=LmsjCjdx2PD-F9Wv&_nc_ht=scontent-hkg4-2.xx&oh=8a5eeacc7eae30256ae2b9091afb397e&oe=60E446A9)
    
**6. Bill Form**
    <br/>
    <br/>
    ![image_bill](https://scontent.fdad3-1.fna.fbcdn.net/v/t1.6435-9/198078709_814940599147207_2396214526646046794_n.jpg?_nc_cat=102&ccb=1-3&_nc_sid=0debeb&_nc_ohc=-tRgZTfcNZsAX-elgsK&_nc_ht=scontent.fdad3-1.fna&oh=142473cff1bd56b66cf205a9be1a708b&oe=60E2B230)

**7. Stadium and Service Order Form**
    <br/>
    <br/>
    ![image_stadiumorder](https://scontent.fdad3-1.fna.fbcdn.net/v/t1.6435-9/195559219_814940739147193_5937328237918344648_n.jpg?_nc_cat=103&ccb=1-3&_nc_sid=0debeb&_nc_ohc=_tmEGFtSiPAAX8Dx3tD&tn=LmsjCjdx2PD-F9Wv&_nc_ht=scontent.fdad3-1.fna&oh=2a43556caf9f8635a60b9fc80133c79a&oe=60E1F86E)
    <br/>
    <br/>
    ![image_serviceorder](https://scontent-hkg4-1.xx.fbcdn.net/v/t1.6435-9/193989042_814940622480538_7967961522847868338_n.jpg?_nc_cat=103&ccb=1-3&_nc_sid=0debeb&_nc_ohc=UaQUVNu4k6UAX90J7w0&_nc_ht=scontent-hkg4-1.xx&oh=222f67cda96cc3bf54f19748c53e51a8&oe=60E31AE5)
    
**8. Print Bill**
    <br/>
    <br/>
    ![image_print](https://scontent.fdad3-3.fna.fbcdn.net/v/t1.6435-9/196645051_814940735813860_6052191270681388999_n.jpg?_nc_cat=100&ccb=1-3&_nc_sid=0debeb&_nc_ohc=O2NPAU6bw5QAX_DFpaS&_nc_ht=scontent.fdad3-3.fna&oh=25545ab27430b1de01a0f51b92a5fd8f&oe=60E16E40)

**9. Statistic Form (Predict by Linear Regression)**
    <br/>
    <br/>
    ![image_history](https://scontent.fdad3-3.fna.fbcdn.net/v/t1.6435-9/198022791_814940472480553_2510342165693489775_n.jpg?_nc_cat=100&ccb=1-3&_nc_sid=0debeb&_nc_ohc=tqc3pJQnvBUAX8pzp9W&_nc_ht=scontent.fdad3-3.fna&oh=aa44926ae1453833f621bcb06d86a903&oe=60E27E0C)
    <br/>
    <br/>
    ![image_statistic](https://scontent.fdad3-3.fna.fbcdn.net/v/t1.6435-9/196306660_814940659147201_617460375946665343_n.jpg?_nc_cat=104&ccb=1-3&_nc_sid=0debeb&_nc_ohc=hQM3dzqbB1EAX9oPkyC&_nc_ht=scontent.fdad3-3.fna&oh=af3cc6497401fa5214ec47a738f2f19f&oe=60E3357A)
	  <br/>
    <br/>
    ![image_predict](https://scontent.fdad3-1.fna.fbcdn.net/v/t1.6435-9/197644724_814940672480533_6489421323108569973_n.jpg?_nc_cat=102&ccb=1-3&_nc_sid=0debeb&_nc_ohc=-rZCc8GstoQAX_Z_cwZ&_nc_ht=scontent.fdad3-1.fna&oh=e23ace753b9c1ca89562aabf17807892&oe=60E41477)	

**10. Setting Form**
    <br/>
    <br/>
    ![image_setting](https://scontent-hkg4-2.xx.fbcdn.net/v/t1.6435-9/195279225_814940415813892_3507506591599574239_n.jpg?_nc_cat=109&ccb=1-3&_nc_sid=0debeb&_nc_ohc=dgF3mJHmhqUAX-NWvGQ&_nc_ht=scontent-hkg4-2.xx&oh=aa4d4aeef1dd7e7bcf175143a487ee82&oe=60E3C2A8)

**11. Beautiful Alert with each Validation Result**
    <br/>
    <br/>
    ![image_alert](https://scontent-hkg4-1.xx.fbcdn.net/v/t1.6435-9/193941902_814940725813861_4694572823386304395_n.jpg?_nc_cat=106&ccb=1-3&_nc_sid=0debeb&_nc_ohc=pQd8jEr4FkwAX-QhGUE&_nc_oc=AQnpuBkf0CznUKXJPKNw_xHQUawRy0XcN5DTxN-gBvsg8Y_C7MNrTZmotZhqZ5djKz73Y9qN3BZ211uy82ca32Pf&_nc_ht=scontent-hkg4-1.xx&oh=6e61542db227d86fddb7d8b011404bb4&oe=60E2192F)

**12. Sorting data by clicking the column header (SortableBindingList)**
    <br/>
    <br/>
    ![image_sort](https://scontent-hkg4-2.xx.fbcdn.net/v/t1.6435-9/195321683_814940665813867_282083044151868099_n.jpg?_nc_cat=110&ccb=1-3&_nc_sid=0debeb&_nc_ohc=UPcmS5nI5PIAX8ciW9w&_nc_ht=scontent-hkg4-2.xx&oh=249afb05c6109571410cd9e0d87e1019&oe=60E256B4)
 

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
* [Chart in WF](https://www.youtube.com/watch?v=gqo2TGpCOlA)
* [StackoverFlow](https://stackoverflow.com/)
* [Choose an Open Source License](https://choosealicense.com)
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
