[Point](../../../../../Point.md) > [Setpoint](../../../../Setpoint.md) > [Temperature_Setpoint](../../../Temperature_Setpoint.md) > [Water_Temperature_Setpoint](../../Water_Temperature_Setpoint.md) > [Hot_Water_Temperature_Setpoint](../Hot_Water_Temperature_Setpoint.md) > [Domestic_Hot_Water_Temperature_Setpoint](Domestic_Hot_Water_Temperature_Setpoint.md) > [Entering_Domestic_Hot_Water_Temperature_Setpoint](.)
# Entering_Domestic_Hot_Water_Temperature_Setpoint
**DTMI:** dtmi:org:brickschema:schema:Brick:Entering_Domestic_Hot_Water_Temperature_Setpoint;1
## Display name
- **en:** Entering Domestic Hot Water Temperature Setpoint
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
