[Point](../../../../Point.md) > [Sensor](../../../Sensor.md) > [Pressure_Sensor](../../Pressure_Sensor.md) > [Differential_Pressure_Sensor](../Differential_Pressure_Sensor.md) > [Hot_Water_Differential_Pressure_Sensor](Hot_Water_Differential_Pressure_Sensor.md) > [Medium_Temperature_Hot_Water_Differential_Pressure_Sensor](.)
# Medium_Temperature_Hot_Water_Differential_Pressure_Sensor
**DTMI:** dtmi:org:brickschema:schema:Brick:Medium_Temperature_Hot_Water_Differential_Pressure_Sensor;1
## Display name
- **en:** Medium Temperature Hot Water Differential Pressure Sensor
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