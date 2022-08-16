  <!DOCTYPE html>
<html lang="en">
    <head>
        <title>
            HTML form ve inputs
        </title>
    </head>
    <body>
        <form>
            <label for="name">Name</label> <br />
            <input type="text" id="name" name="name" /> <br />
            <label for="email">E-mail</label> <br />
            <input type="email" id="email" name="email" / > <br />
            <label for="password">Password</label> <br/>
            <input type="password" name="password" id="password" /> <br />
            <label for="date">Date</label> <br />
            <input type="date" id="date" name="date" /> <br />
            Gender <br />
            Male
            <input type="radio" name="gender" value="Male" />
            Female 
            <input type="radio" name="gender"  value="Female" />
            Other
            <input type="radio" name="gender"  value="Other" / > <br />
            Hobbies <br />
            Technology
            <input type="checkbox" name="tech" id="tech" />
            Music
            <input type="checkbox" name="music" id="music" />
            Art
            <input type="checkbox" name="art"  id="art" /> <br />

            <input type="submit" value="Submit" >
            <button type="reset">Sifirla</button>
     </form>
    </body>
