[Point](../../Point.md) > [Setpoint](../Setpoint.md) > [CO2_Setpoint](CO2_Setpoint.md) > [Return_Air_CO2_Setpoint](.)
# Return_Air_CO2_Setpoint

**Display name:** Return Air CO2 Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Return_Air_CO2_Setpoint;1

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
