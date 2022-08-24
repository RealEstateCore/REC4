[Point](../../Point.md) > [Sensor](../Sensor.md) > [Illuminance_Sensor](Illuminance_Sensor.md) > [Outside_Illuminance_Sensor](.)
# Outside_Illuminance_Sensor
**DTMI:** dtmi:org:brickschema:schema:Brick:Outside_Illuminance_Sensor;1
## Display name
- **en:** Outside Illuminance Sensor
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
