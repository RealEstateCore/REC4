[Point](../../../../Point.md) > [Sensor](../../../Sensor.md) > [Temperature_Sensor](../../Temperature_Sensor.md) > [Air_Temperature_Sensor](../Air_Temperature_Sensor.md) > [Outside_Air_Temperature_Sensor](Outside_Air_Temperature_Sensor.md) > [Outside_Air_Wet_Bulb_Temperature_Sensor](.)
# Outside_Air_Wet_Bulb_Temperature_Sensor
**DTMI:** dtmi:org:brickschema:schema:Brick:Outside_Air_Wet_Bulb_Temperature_Sensor;1
## Display name
- **en:** Outside Air Wet Bulb Temperature Sensor
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