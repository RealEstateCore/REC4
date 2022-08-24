[Point](../../Point.md) > [Sensor](../Sensor.md) > [Flow_Sensor](Flow_Sensor.md) > [Natural_Gas_Flow_Sensor](.)
# Natural_Gas_Flow_Sensor
**DTMI:** dtmi:org:brickschema:schema:Brick:Natural_Gas_Flow_Sensor;1
## Display name
- **en:** Natural Gas Flow Sensor
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