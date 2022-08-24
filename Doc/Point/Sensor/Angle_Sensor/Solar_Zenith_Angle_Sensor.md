[Point](../../Point.md) > [Sensor](../Sensor.md) > [Angle_Sensor](Angle_Sensor.md) > [Solar_Zenith_Angle_Sensor](.)
# Solar_Zenith_Angle_Sensor
**DTMI:** dtmi:org:brickschema:schema:Brick:Solar_Zenith_Angle_Sensor;1
## Display name
- **en:** Solar Zenith Angle Sensor
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