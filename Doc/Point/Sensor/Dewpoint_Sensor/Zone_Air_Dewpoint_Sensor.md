[Point](../../Point.md) > [Sensor](../Sensor.md) > [Dewpoint_Sensor](Dewpoint_Sensor.md) > [Zone_Air_Dewpoint_Sensor](.)
# Zone_Air_Dewpoint_Sensor
**DTMI:** dtmi:org:brickschema:schema:Brick:Zone_Air_Dewpoint_Sensor;1
## Display name
- **en:** Zone Air Dewpoint Sensor
## Description
## Relationships
### Inherited Relationships
* **dtmi:org:brickschema:schema:Brick:Point;1:** isPointOf
## Properties
|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|tags|**en**: Tags|**en**: Brick tags associated with this interface.|array (string)|False|
### Inherited Properties
* **dtmi:org:brickschema:schema:Brick:Point;1:** aggregate, customTags, externalIds, hasQuantity, hasSubstance, lastKnownValue, name
## Target Of
### Inherited
* Asset.hasPoint
* EquipmentCollection.hasPoint
* ActuationEvent.targetPoint
* ExceptionEvent.sourcePoint
* ObservationEvent.sourcePoint
* ServiceObject.producedBy
* Architecture.hasPoint
