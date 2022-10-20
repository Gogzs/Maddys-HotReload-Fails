# Hot Reload Fail
This repo demonstrates the hot reload issues we ran into during the development of our new client app.

If you run the app in debug mode, and try to change for example the VerticalOptions of the custom entry control we made (we called it InputTextField) you'll notice that hot reload won't work properly (for example, change it from "End" to "Start" and instead of going to the top, it'll stay where it is). The same is true for changing the "IsPassword" property on the second InputTextField.

The same doesn't happen if you use the standard Entry controls (they do react propely to all changes). You can test out with the code that is commented out in the MainPage.xaml. Stop Debug -> Comment out the InputTextField controls, remove comment tags from Entry controls -> Build -> Debug

## Fun part

If you run the app as it was (with the InputTextField controls) there's a workaround how to get them to hot reload properly. 

While debugging, comment them out so they completely disappear. Remove the comment tags afterwards so they reappear and from that moment, hot reload for them will work correctly (they wil react to changing properties in the XAML).

We found this annoying because we use hot reload for final tweaks to our designs (change colors, margins, paddings etc.) and on such custom controls, hot reload would always be broken upon startup unless we comment them out and bring them back in.
