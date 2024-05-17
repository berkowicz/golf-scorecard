# Golf Scorecard
## Intro
This is a fullstack web application using MVC-pattern.
I've decided to do abstraction-layers on serverside in the Services folder example: 
Controller -> IGameService -> GameService.

<div align="center">

</div>


## Setup
 - React / ASP.NET Core
 - Entity Framework Core
 - Code First with SQL Server

## Key Feature
- Player will get exact stroke difference to their handicap

## The Code
|**Services**|**Breakdown**|
|-|-|
|GameService|Logic that returns data for selected course|
|SelectService|Handles input on homescreen and calculate strokes|
<br>

|**Data Base**|**Breakdown**|
|-|-|
|Course|Table contains basic data on course (par and name)|
|Hole|Table contains all data for each hole; FK to Course|
|SlopeRating| Contains data to calculate strokes based on user input; FK to Course, Tee and Gender|
|Gender|Table contains basic data on gender (man or woman)|
|Tee|Table contains basic data on tee (yellow or red); FK to Course|
<br>


|**Shared/ViewModels**|**Breakdown**|
|-|-|
|HoleViewModel|Model used to create HolesViewModel|
|HolesViewModel|Model used to send list of hole data to game client |
|HomeViewModel|Model used to render dropdown on homescreen|
|NewGameDataViewModel|Model used to retrive data from clients input|
|StrokesViewModel|Model used to send send users extra strokes to client|

## Database Diagram
<div align="center">
![db-diagram-golf-scorecard](https://github.com/berkowicz/golf-scorecard/assets/112638774/17a7bef0-75c3-423e-a91d-692ed0140d65)
</div>

## Contributors

<table>
  <tr>
    <td align="center"><a href="https://github.com/berkowicz"><img src="https://avatars.githubusercontent.com/u/112638774?v=4" width="100px;" alt="Daniel Bekowicz"/><br /><sub><b>Daniel Berkowicz</b></sub></a><br /></td>
    </tr>
</table>
