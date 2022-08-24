[Point](../../../Point.md) > [Setpoint](../../Setpoint.md) > [Differential_Setpoint](../Differential_Setpoint.md) > [Differential_Temperature_Setpoint](Differential_Temperature_Setpoint.md) > [Water_Differential_Temperature_Setpoint](.)
# Water_Differential_Temperature_Setpoint

**Display name:** Water Differential Temperature Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Water_Differential_Temperature_Setpoint;1

---
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
