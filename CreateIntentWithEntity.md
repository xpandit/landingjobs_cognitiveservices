# Now for the intent choosewhen with datetime

## Let's add the prebuilt entity DateTime v2

Back in [LUIS](https://www.luis.ai), and our app, add a prebuilt entity - datetimev2

![Add prebuild entity](screens/1_2_2_1-CreateEntityAddPreBuildEntity.jpg)

![Add prebuild entity 1](screens/1_2_2_2-CreateEntityAddPreBuildEntity_1.jpg)

## Create the intent choosewhen

![create choose when intent](screens/1_2_2_3-CreateEntityAddIntentChooseWhen.jpg)

And let's start adding utterances:

* Can I drive a bike tomorrow?
* Is it raining today?
* Will it be a day to drive today?
* Should I take a car today?

![add utterances](screens/1_2_2_4-CreateEntityAddUtterances.jpg)

## Train and publish again

Add the new intent to our bot: bot

![Add intent to function](screens/1_2_2_5-CreateEntityAddIntentToFunction.jpg)

Or just paste the code from here: [bot](exercises/ex2/BasicLuisDialog.csx)

Test the bot

![test entity in web chat](screens/1_2_2_6-CreateEntityTestInChat.jpg)

here is how it works: [datetime](https://docs.microsoft.com/en-us/azure/cognitive-services/luis/luis-reference-prebuilt-datetimev2)