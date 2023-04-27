<a name="readme-top"></a>



<!-- PROJECT SHIELDS -->
<!--
*** I'm using markdown "reference style" links for readability.
*** Reference links are enclosed in brackets [ ] instead of parentheses ( ).
*** See the bottom of this document for the declaration of the reference variables
*** for contributors-url, forks-url, etc. This is an optional, concise syntax you may use.
*** https://www.markdownguide.org/basic-syntax/#reference-style-links
-->
[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]
[![LinkedIn][linkedin-shield]][linkedin-url]



<!-- PROJECT LOGO -->
<br />
<div align="center">
  <a href="https://codewithmosh.com/">
    <img src="https://process.fs.teachablecdn.com/ADNupMnWyR7kCWRvm76Laz/resize=height:120/https://file-uploads.teachablecdn.com/be9f614a58674fe1a67044fb1158fff1/79b0bba8c4c441e5bbe715364cb9e770" alt="Logo">
  </a>

  <h3 align="center">The Complete ASP.NET MVC 5 Course</h3>

  <p align="center">
    A web application built from scratch with C# and ASP.NET Core
    <br />
    <a href="https://github.com/lorenarms/Vidly/tree/master/Vidly"><strong>Explore the files »</strong></a>
    <br />
    <br />
    <a href="https://github.com/othneildrew/Best-README-Template/issues">View the demo</a>
    ·
    <a href="https://www.youtube.com/watch?v=ltE63Xm3bh4&list=PLhz6FAyiBzY6kAOeiksSwaB5887EGQIyY">See more projects</a>
    ·
    <a href="https://codewithmosh.com/p/asp-net-mvc">Get the course</a>
  </p>
</div>



<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li>
      <a href="#screenshots">Screenshots</a>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li><a href="#extras">Extras</a></li>
    <li><a href="#roadmap">Roadmap</a></li>
    <li><a href="#contributing">Contributing</a></li>
    <li><a href="#license">License</a></li>
    <li><a href="#contact">Contact</a></li>
    <li><a href="#acknowledgments">Acknowledgments</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## About The Project

[![Product Name Screen Shot][product-screenshot]](https://example.com)

This project, called "Vidly", is an ASP.NET Core web application built with C# (and a wee bit'o javascript). The project is a database for a video rental service consisting of a list of Movies to rent and Customers who can rent those movies. The proeject was built folowing the tutorial by Mosh Hamedani, which can be found <a href="https://codewithmosh.com/p/asp-net-mvc">here</a>.

Why did I choose this course?
* I am passionate about C# coding and web development, and this course was a great way for me to get familiar with the ASP.NET and Entity frameworks
* The course is quite old and therefore gave me a great opportunity to practice problem-solving as some of the techniques are outdated (but still work)
* I think Mosh is awesome and a great teacher, this is not my first course with him! :smile:

As mentioned above, there were a few things in the course that are no longer applicable because of changes to the way MVC is built in Visual Studio 2022. That's okay! It was a great opportunity for me to work through real-world problems and solve them, and in the end there was *nothing* that I couldn't complete.

Keep reading to see project screenshots and hear about my process!

<p align="right">(<a href="#readme-top">back to top</a>)</p>



### Built With

This project was built with the following applications, languages, and libraries. Additionally, the project makes use of <a href="https://bootboxjs.com/">Bootbox.js</a> for custom dialogs, and <a href="https://datatables.net/">Datatables</a> for easy-to-use database display.

[![VS][Visual Studio]][vs-url]
[![dotnet][dotnet]][net-url]
[![csharp][csharp]][csharp-url]
[![Bootstrap][Bootstrap.com]][Bootstrap-url]
[![JQuery][JQuery.com]][JQuery-url]

[Visual Studio]: https://img.shields.io/badge/visual_studio_2022-ffffff?style=for-the-badge&logo=visualstudio&logoColor=purple
[vs-url]: https://visualstudio.microsoft.com/vs/
[dotnet]: https://img.shields.io/badge/Microsoft_.net-ffffff?style=for-the-badge&logo=dotnet&logoColor=purple
[net-url]: https://visualstudio.microsoft.com/vs/](https://dotnet.microsoft.com/en-us/
[csharp]: https://img.shields.io/badge/C_Sharp-590ec4?style=for-the-badge&logo=csharp&logoColor=white
[csharp-url]: https://dotnet.microsoft.com/en-us/languages/csharp

<p align="right">(<a href="#readme-top">back to top</a>)</p>

## Screenshots

<table>
  <tr>
    <td><img src="https://github.com/lorenarms/Vidly/blob/master/Vidly/Screenshots/Movies%20index.png" alt="MovieIndex" width="auto">
    <td><img src="https://github.com/lorenarms/Vidly/blob/master/Vidly/Screenshots/Movies%20edit%20page.png" alt="MovieEdit" width="auto">
  </tr>
  <tr>
    <td>Movie Index</td>
    <td>Movie Edit Webform</td>
  </tr>
  <tr>
    <td><img src="https://github.com/lorenarms/Vidly/blob/master/Vidly/Screenshots/Movie%20api%20getallmovies.png" alt="MovieAPI" width="auto">
    <td><img src="https://github.com/lorenarms/Vidly/blob/master/Vidly/Screenshots/Movie%20api%20getonemovie.png" alt="MovieAPI" width="auto">
  </tr>
  <tr>
    <td>Movie API "GetAllMovies"</td>
    <td>Movie API "GetMovieById"</td>
  </tr>
</table>

_Make sure you <a href="#">view the demo</a> to see more pages in action!_
_Also, here's some <a href="https://github.com/lorenarms/Vidly/tree/master/Vidly/Screenshots">more screenshots</a> if you're interested_

<!-- GETTING STARTED -->
## Getting Started

To copy this project I first recommend getting the course and following along, it was a great experience and you will learn a lot. If you wish to fork this project from me, please feel free to do so and continue to build onto it.

### Prerequisites

You'll want to start with <a href="https://visualstudio.microsoft.com/">Visual Studio</a>

### Installation

_Installing the various extensions can be done via the VS Package Manager Console, or by right-clicking the project and selecting "Add > Client-Side Library"_

I will provide a video in the near future showing how to do this.

<p align="right">(<a href="#readme-top">back to top</a>)</p>


<!-- OTHER ITEMS -->
## Extras

In addition to the course material, I wished to learn more about the ASP Identity Library and how Users and Roles are managed. In this project, I added a page to add new roles for users to take on when they register. As you can see by the below screenshot, when a new user registers they have a dropdown option to select which 'role' they wish to be placed into ('user' or 'admin').

 <img src="https://github.com/lorenarms/Vidly/blob/master/Vidly/Screenshots/New%20user%20registration.png" alt="Registration">
 
 There is a page dedicated to creating new roles that only a user logged in as 'admin' can access.
 
 <img src="https://github.com/lorenarms/Vidly/blob/master/Vidly/Screenshots/Roles%20page.png" alt="Registration">

_For more examples, please refer to the [Documentation](https://github.com/lorenarms/Vidly/tree/master/Vidly/Screenshotsm)_

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- ROADMAP -->
## Roadmap

- [x] Add Roles
- [ ] Add more styling
- [ ] Add option for admin to edit users

See the [open issues](https://github.com/lorenarms/Vidly/issues) for a full list of proposed features (and known issues).

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- CONTRIBUTING -->
## Contributing

If you have a suggestion that would make this better, please fork the repo and create a pull request. You can also simply open an issue with the tag "enhancement".
Don't forget to give the project a star! Thanks again!

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- LICENSE -->
## License

Currently there is no license for this application, it is free to use by anyone who needs it. Please consider letting me know if it was helpful at all, or any additions you can propose (see the <a href="#contributing">contributing</a> section)

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- CONTACT -->
## Contact

<p>Check out my <a href="https://www.youtube.com/channel/UCGtp8PRHgPCQHYoSxbMST8A" target="_blank">YouTube channel</a> for more videos about coding projects I've done.</p>
<p>Also, check out my <a href="http://artllj.com" target="_blank">Personal Website</a> for more information about me, and my <a href="https://www.linkedin.com/in/lorenarms95/" target="_blank">LinkedIn</a> to see if I'd be a good fit for your team. </p>
<h3>Thanks for stopping by!</h3>
<img src="https://github.com/lorenarms/SNHU_CS_370_Emerging_Trends_in_CS/blob/main/images/profile.png" alt="[picture of me]" style="width:100px;">
<p>much love
-L
</p>

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- ACKNOWLEDGMENTS -->
## Acknowledgments

* [Best README Template](https://github.com/lorenarms/README-Template)

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/lorenarms/vidly.svg?style=for-the-badge
[contributors-url]: https://github.com/lorenarms/Vidly/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/lorenarms/vidly.svg?style=for-the-badge
[forks-url]: https://github.com/lorenarms/Vidly/forks
[stars-shield]: https://img.shields.io/github/stars/lorenarms/vidly.svg?style=for-the-badge
[stars-url]: https://github.com/lorenarms/Vidly/stargazers
[issues-shield]: https://img.shields.io/github/issues/lorenarms/vidly.svg?style=for-the-badge
[issues-url]: https://github.com/lorenarms/Vidly/issues
[license-shield]: https://img.shields.io/github/license/lorenarms/vidly.svg?style=for-the-badge
[license-url]: https://github.com/lorenarms/vidly/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://linkedin.com/in/lorenarms95


[product-screenshot]: https://github.com/lorenarms/Vidly/blob/master/Vidly/Screenshots/Movies%20index.png


[Next.js]: https://img.shields.io/badge/next.js-000000?style=for-the-badge&logo=nextdotjs&logoColor=white
[Next-url]: https://nextjs.org/
[React.js]: https://img.shields.io/badge/React-20232A?style=for-the-badge&logo=react&logoColor=61DAFB
[React-url]: https://reactjs.org/
[Vue.js]: https://img.shields.io/badge/Vue.js-35495E?style=for-the-badge&logo=vuedotjs&logoColor=4FC08D
[Vue-url]: https://vuejs.org/
[Angular.io]: https://img.shields.io/badge/Angular-DD0031?style=for-the-badge&logo=angular&logoColor=white
[Angular-url]: https://angular.io/
[Svelte.dev]: https://img.shields.io/badge/Svelte-4A4A55?style=for-the-badge&logo=svelte&logoColor=FF3E00
[Svelte-url]: https://svelte.dev/
[Laravel.com]: https://img.shields.io/badge/Laravel-FF2D20?style=for-the-badge&logo=laravel&logoColor=white
[Laravel-url]: https://laravel.com
[Bootstrap.com]: https://img.shields.io/badge/Bootstrap-563D7C?style=for-the-badge&logo=bootstrap&logoColor=white
[Bootstrap-url]: https://getbootstrap.com
[JQuery.com]: https://img.shields.io/badge/jQuery-0769AD?style=for-the-badge&logo=jquery&logoColor=white
[JQuery-url]: https://jquery.com 
