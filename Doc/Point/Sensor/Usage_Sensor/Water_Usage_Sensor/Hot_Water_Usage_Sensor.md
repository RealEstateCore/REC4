[Point](../../../Point.md) > [Sensor](../../Sensor.md) > [Usage_Sensor](../Usage_Sensor.md) > [Water_Usage_Sensor](Water_Usage_Sensor.md) > [Hot_Water_Usage_Sensor](.)
# Hot_Water_Usage_Sensor
**DTMI:** dtmi:org:brickschema:schema:Brick:Hot_Water_Usage_Sensor;1
## Display name
- **en:** Hot Water Usage Sensor
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